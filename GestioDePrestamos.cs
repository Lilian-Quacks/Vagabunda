using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Vagabunda
{
    public partial class GestioDePrestamos : Form
    {
        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Vagabunda;Integrated Security=True;";
        int idPrestamoSeleccionado = -1;

        public GestioDePrestamos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvPrestamos.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            dgvPrestamos.ColumnHeadersDefaultCellStyle.BackColor;

            dgvPrestamos.RowHeadersDefaultCellStyle.SelectionBackColor =
            dgvPrestamos.RowHeadersDefaultCellStyle.BackColor;
        }

        private void GestioDePrestamos_Load(object sender, EventArgs e)
        {
            if (cbeEstatus.Items.Count == 0)
            {
                cbeEstatus.Items.Add("Activo");
                cbeEstatus.Items.Add("Devuelto");
            }
            cbeEstatus.SelectedIndex = 0;

            dtpFechaSalida.Value = DateTime.Now;
            dtpFechaLimite.Value = DateTime.Now.AddDays(7); 

            ConsultarPrestamos();
            if (dgvPrestamos.Columns.Count > 0) dgvPrestamos.Columns[0].Visible = false;
        }

        private void ConsultarPrestamos(string filtro = "", bool porUsuarioExacto = false)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    string query = @"SELECT p.Prestamo_ID, u.Nombre AS Usuario, l.Titulo AS Libro,
                                     p.Fecha_Salida, p.Fecha_Limite, p.Estatus
                                     FROM Prestamos p
                                     INNER JOIN Usuarios u ON p.Usuario_ID = u.Usuario_ID
                                     INNER JOIN Libros l ON p.Libros_ID = l.Libros_ID";

                    if (porUsuarioExacto)
                    {
                        query += " WHERE u.Usuario_ID = (SELECT Usuario_ID FROM Usuarios WHERE Nombre = @filtro OR Telefono = @filtro OR Email = @filtro OR CAST(Usuario_ID AS VARCHAR) = @filtro)";
                    }
                    else if (!string.IsNullOrEmpty(filtro))
                    {
                        query += " WHERE (u.Nombre LIKE @filtro OR u.Telefono LIKE @filtro OR u.Email LIKE @filtro OR l.Titulo LIKE @filtro) AND p.Estatus != 'Devuelto'";
                    }
                    else
                    {
                        query += " WHERE p.Estatus != 'Devuelto'";
                    }

                    query += @" ORDER BY 
                                CASE 
                                    WHEN p.Estatus = 'Activo' THEN 1 
                                    WHEN p.Estatus = 'Retrasado' THEN 1 
                                    ELSE 2 
                                END ASC, p.Fecha_Limite DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@filtro", porUsuarioExacto ? filtro : "%" + filtro + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    dgvPrestamos.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvPrestamos.Rows.Add(
                            row["Prestamo_ID"], // Coincide con el nombre en SQL
                            row["Usuario"],
                            row["Libro"],
                            Convert.ToDateTime(row["Fecha_Salida"]).ToShortDateString(),
                            Convert.ToDateTime(row["Fecha_Limite"]).ToShortDateString(),
                            row["Estatus"]
                        );
                    }
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al cargar préstamos: " + ex.Message); 
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtLibro.Text))
            {
                MessageBox.Show("Complete los campos de Usuario y Libro.");
                return;
            }

            if (idPrestamoSeleccionado != -1)
            {
                DialogResult res = MessageBox.Show("¿Confirmar cambio de estatus?", "Validar Modificación", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) return;
            }

            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();
                SqlTransaction transaccion = con.BeginTransaction();

                try
                {
                    int uID = ObtenerUsuarioID(txtUsuario.Text.Trim());
                    int lID = ObtenerLibroID(txtLibro.Text.Trim());
                    string query = @"
                    INSERT INTO Prestramos
                    (Fecha_Salida, Fecha_Limite, Estatus, Usuario_ID, Libros_ID, Bibliotecario_ID)
                    VALUES (@salida, @limite, @estatus, @usuario, @libro, 1)
                    ";

                    if (uID == 0 || lID == 0) { MessageBox.Show("Usuario o Libro no válidos."); return; }

                    if (idPrestamoSeleccionado == -1)
                    {
                        string check = "SELECT COUNT(*) FROM Prestamos WHERE Usuario_ID = @uid AND Estatus = 'Retrasado'";
                        SqlCommand vCmd = new SqlCommand(check, con, transaccion);
                        vCmd.Parameters.AddWithValue("@uid", uID);
                        if ((int)vCmd.ExecuteScalar() >= 3)
                        {
                            MessageBox.Show("USUARIO BLOQUEADO: Tiene 3 o más préstamos retrasados.");
                            return;
                        }

                        int bID = 0;
                        SqlCommand cmdB = new SqlCommand("SELECT TOP 1 Bibliotecario_ID FROM Bibliotecario", con, transaccion);
                        object resB = cmdB.ExecuteScalar();
                        if (resB != null) bID = Convert.ToInt32(resB);
                        if (bID == 0) throw new Exception("No hay bibliotecarios registrados.");

                        string queryI = @"INSERT INTO Prestamos (Fecha_Salida, Fecha_Limite, Estatus, Usuario_ID, Libros_ID, Bibliotecario_ID)
                                  VALUES (@salida, @limite, @estatus, @usuario, @libro, @biblio)";
                        SqlCommand cmdI = new SqlCommand(queryI, con, transaccion);
                        cmdI.Parameters.AddWithValue("@salida", dtpFechaSalida.Value);
                        cmdI.Parameters.AddWithValue("@limite", dtpFechaLimite.Value);
                        cmdI.Parameters.AddWithValue("@estatus", cbeEstatus.Text);
                        cmdI.Parameters.AddWithValue("@usuario", uID);
                        cmdI.Parameters.AddWithValue("@libro", lID);
                        cmdI.Parameters.AddWithValue("@biblio", bID);
                        cmdI.ExecuteNonQuery();

                        SqlCommand cmdLibro = new SqlCommand("UPDATE Libros SET Estatus_Operativo = 'Prestado' WHERE Libros_ID = @lid", con, transaccion);
                        cmdLibro.Parameters.AddWithValue("@lid", lID);
                        cmdLibro.ExecuteNonQuery();
                    }
                    else
                    {
                        string queryU = "UPDATE Prestamos SET Estatus = @estatus WHERE Prestamo_ID = @id";
                        SqlCommand cmdU = new SqlCommand(queryU, con, transaccion);
                        cmdU.Parameters.AddWithValue("@estatus", cbeEstatus.Text);
                        cmdU.Parameters.AddWithValue("@id", idPrestamoSeleccionado);
                        cmdU.ExecuteNonQuery();

                        if (cbeEstatus.Text == "Devuelto")
                        {
                            decimal adeudo = 0;

                            SqlCommand cmdAdeudo = new SqlCommand(@"
                            SELECT ISNULL(Adeudo_Pendiente,0)
                            FROM Usuarios
                            WHERE Usuario_ID = @uid",
                            con,
                            transaccion);

                            cmdAdeudo.Parameters.AddWithValue("@uid", uID);

                            adeudo = Convert.ToDecimal(cmdAdeudo.ExecuteScalar());

                            if (adeudo > 0)
                            {
                                DialogResult pago =
                                    MessageBox.Show(
                                    "El usuario tiene una multa pendiente de $" +
                                    adeudo +
                                    ".\n\n¿Desea marcarla como PAGADA?",
                                    "Pago de multa",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                                if (pago == DialogResult.No)
                                {
                                    MessageBox.Show(
                                        "No se puede marcar como devuelto hasta pagar la multa.");

                                    transaccion.Rollback();
                                    return;
                                }

                                SqlCommand cmdLiquidar = new SqlCommand(@"
                                UPDATE Usuarios
                                SET Adeudo_Pendiente = 0
                                WHERE Usuario_ID = @uid",
                                con,
                                transaccion);

                                cmdLiquidar.Parameters.AddWithValue("@uid", uID);

                                cmdLiquidar.ExecuteNonQuery();

                                SqlCommand cmdPago = new SqlCommand(@"
                                UPDATE Penalizacion
                                SET Pagado = 1
                                WHERE Prestamo_ID = @prestamo",
                                con,
                                transaccion);

                                cmdPago.Parameters.AddWithValue(
                                    "@prestamo",
                                    idPrestamoSeleccionado);

                                cmdPago.ExecuteNonQuery();
                            }

                            SqlCommand cmdFecha = new SqlCommand(@"
                            UPDATE Prestamos
                            SET Fecha_Devolucion = GETDATE()
                            WHERE Prestamo_ID = @id",
                            con,
                            transaccion);

                            cmdFecha.Parameters.AddWithValue(
                                "@id",
                                idPrestamoSeleccionado);

                            cmdFecha.ExecuteNonQuery();

                            SqlCommand cmdLibro = new SqlCommand(@"UPDATE Libros
                            SET Estatus_Operativo = 'Disponible'
                            WHERE Libros_ID = @lid",
                            con,
                            transaccion);

                            cmdLibro.Parameters.AddWithValue("@lid", lID);

                            cmdLibro.ExecuteNonQuery();
                        }
                    }

                    transaccion.Commit();
                    MessageBox.Show("Operación exitosa.");
                    Limpiar();
                    ConsultarPrestamos();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPrestamoSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un préstamo de la lista.");
                return;
            }

            var confirm = MessageBox.Show("¿Eliminar préstamo?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(cadena))
                    {
                        string query = "DELETE FROM Prestramos WHERE Prestramo_ID=@id";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", idPrestamoSeleccionado);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Préstamo eliminado correctamente");

                        Limpiar();
                        ConsultarPrestamos();
                        idPrestamoSeleccionado = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                InfoUsuarios ver = new InfoUsuarios();
                if (ver.ShowDialog() == DialogResult.OK)
                {
                    txtUsuario.Text = ver.NombreSeleccionado;
                    ConsultarPrestamos(txtUsuario.Text, true); 
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                BuscarUsuarioPorDato(txtUsuario.Text.Trim());
            }
        }

        private void txtLibro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                InfoLiibros ver = new InfoLiibros();
                if (ver.ShowDialog() == DialogResult.OK)
                {
                    BuscarLibroPorCodigo(ver.IsbnSeleccionado);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                BuscarLibroPorCodigo(txtLibro.Text.Trim());
            }
        }

        private void BuscarUsuarioPorDato(string dato)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Nombre FROM Usuarios WHERE Telefono = @dato OR Email = @dato OR CAST(Usuario_ID AS VARCHAR) = @dato";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dato", dato);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null) 
                { 
                    txtUsuario.Text = result.ToString(); 
                    ConsultarPrestamos(txtUsuario.Text, true); 
                }
                else { MessageBox.Show("Usuario no encontrado por ID, Teléfono o Correo."); }
            }
        }

        private void BuscarLibroPorCodigo(string isbn)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Titulo FROM Libros WHERE ISBN = @dato";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dato", isbn);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null) { txtLibro.Text = result.ToString(); }
                else { MessageBox.Show("Libro no encontrado."); }
            }
        }

        private void dgvPrestamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvPrestamos.Rows[e.RowIndex];
                idPrestamoSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtUsuario.Text = fila.Cells[1].Value.ToString();
                txtLibro.Text = fila.Cells[2].Value.ToString();
                dtpFechaSalida.Value = fila.Cells[3].Value != null ? Convert.ToDateTime(fila.Cells[3].Value) : DateTime.Now;
                dtpFechaLimite.Value = fila.Cells[4].Value != null ? Convert.ToDateTime(fila.Cells[4].Value) : DateTime.Now;
                cbeEstatus.Text = fila.Cells[5].Value.ToString();
                txtUsuario.ReadOnly = true; txtLibro.ReadOnly = true;
            }
        }

        private void Limpiar()
        {
            txtUsuario.Clear(); txtLibro.Clear();
            txtUsuario.ReadOnly = false; txtLibro.ReadOnly = false;
            cbeEstatus.SelectedIndex = 0; idPrestamoSeleccionado = -1;
            dtpFechaSalida.Value = DateTime.Now;
            dtpFechaLimite.Value = DateTime.Now.AddDays(7);
        }

        private int ObtenerUsuarioID(string criterio)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Usuario_ID FROM Usuarios WHERE Nombre = @c OR Telefono = @c OR Email = @c OR CAST(Usuario_ID AS VARCHAR) = @c";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@c", criterio); con.Open();
                object res = cmd.ExecuteScalar(); return res != null ? Convert.ToInt32(res) : 0;
            }
        }

        private int ObtenerLibroID(string titulo)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                SqlCommand cmd = new SqlCommand("SELECT Libros_ID FROM Libros WHERE Titulo = @t", con);
                cmd.Parameters.AddWithValue("@t", titulo); con.Open();
                object res = cmd.ExecuteScalar(); return res != null ? Convert.ToInt32(res) : 0;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ConsultarPrestamos(txtBusqueda.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        // cambios mios de maldonado
        private void dgvPrestamos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 1. Forzamos a que el Grid deje de editar y guarde el cambio en su memoria interna
                dgvPrestamos.EndEdit();

                // 2. Ejecutamos la actualización a la base de datos
                ActualizarEstatusDesdeGrid();

                // 3. Evitamos que el Enter mueva el cursor a la fila de abajo antes de tiempo
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void ActualizarEstatusDesdeGrid()
        {
            if (dgvPrestamos.CurrentRow == null) return;

            try
            {
                DataGridViewRow fila = dgvPrestamos.CurrentRow;

                // IMPORTANTE: Verifica que estos índices coincidan con tus columnas
                // Celda 0 = Prestramo_ID, Celda 5 = Estatus
                int id = Convert.ToInt32(fila.Cells[0].Value);
                string nuevoEstatus = fila.Cells[5].Value.ToString();

                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    // Al ejecutar este UPDATE se dispara el Trigger TR_GenerarPenalizacionSemanal
                    string query = "UPDATE Prestramos SET Estatus = @estatus WHERE Prestramo_ID = @id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@estatus", nuevoEstatus);
                    cmd.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Estatus actualizado en BD. El Trigger ha procesado la penalización si aplica.");
                    }

                    // Recargamos para ver los datos frescos del servidor
                    ConsultarPrestamos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}