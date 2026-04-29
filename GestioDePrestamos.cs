using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vagabunda
{
    public partial class GestioDePrestamos : Form
    {
        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Gestión para Sala de Lectura;Integrated Security=True;";

        int idPrestamoSeleccionado = 0;

        public GestioDePrestamos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Load += GestioDePrestamos_Load;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;

            btnGuardar.Click += btnGuardar_Click;
            btnEliminar.Click += btnEliminar_Click;
        }

        private void GestioDePrestamos_Load(object sender, EventArgs e)
        {
            if (cbeEstatus.Properties.Items.Count == 0)
            {
                cbeEstatus.Properties.Items.Add("Activo");
                cbeEstatus.Properties.Items.Add("Devuelto");
                cbeEstatus.Properties.Items.Add("Retrasado");
            }

            ConsultarPrestamos();
        }

        private void ConsultarPrestamos(string filtro = "")
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    string query = @"
                    SELECT p.Prestamo_ID,
                           u.Nombre AS Usuario,
                           l.Titulo AS Libro,
                           p.Fecha_Salida,
                           p.Fecha_Limite,
                           p.Estatus
                    FROM Prestamos p
                    INNER JOIN Usuarios u ON p.Usuario_ID = u.Usuario_ID
                    INNER JOIN Libros l ON p.Libros_ID = l.Libros_ID
                    ";

                    if (!string.IsNullOrEmpty(filtro))
                    {
                        query += " WHERE u.Nombre LIKE @filtro OR l.Titulo LIKE @filtro";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    if (!string.IsNullOrEmpty(filtro))
                        da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPrestamos.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        dgvPrestamos.Rows.Add(
                            row["Prestamo_ID"],
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int ObtenerUsuarioID(string nombre)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Usuario_ID FROM Usuarios WHERE Nombre = @nombre";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", nombre);

                con.Open();
                object result = cmd.ExecuteScalar();

                return result != null ? Convert.ToInt32(result) : 0;
            }
        }


        private int ObtenerLibroID(string titulo)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT Libros_ID FROM Libros WHERE Titulo = @titulo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@titulo", titulo);

                con.Open();
                object result = cmd.ExecuteScalar();

                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtLibro.Text))
            {
                MessageBox.Show("Completa los campos.");
                return;
            }

            int usuarioID = ObtenerUsuarioID(txtUsuario.Text.Trim());
            int libroID = ObtenerLibroID(txtLibro.Text.Trim());

            if (usuarioID == 0)
            {
                MessageBox.Show("Usuario no existe");
                return;
            }

            if (libroID == 0)
            {
                MessageBox.Show("Libro no existe");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    string query = @"
                    INSERT INTO Prestamos
                    (Fecha_Salida, Fecha_Limite, Estatus, Usuario_ID, Libros_ID, Bibliotecario_ID)
                    VALUES (@salida, @limite, @estatus, @usuario, @libro, 1)
                    ";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@salida", dtpFechaSalida.Value);
                    cmd.Parameters.AddWithValue("@limite", dtpFechaLimite.Value);
                    cmd.Parameters.AddWithValue("@estatus", cbeEstatus.Text);
                    cmd.Parameters.AddWithValue("@usuario", usuarioID);
                    cmd.Parameters.AddWithValue("@libro", libroID);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    SqlCommand update = new SqlCommand(
                        "UPDATE Usuarios SET Prestamos_Activos = Prestamos_Activos + 1 WHERE Usuario_ID=@id", con);
                    update.Parameters.AddWithValue("@id", usuarioID);
                    update.ExecuteNonQuery();

                    MessageBox.Show("Préstamo registrado");

                    Limpiar();
                    ConsultarPrestamos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPrestamoSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un préstamo.");
                return;
            }

            var confirm = MessageBox.Show("¿Eliminar préstamo?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(cadena))
                    {
                        string query = "DELETE FROM Prestamos WHERE Prestamo_ID=@id";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", idPrestamoSeleccionado);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Eliminado");

                        Limpiar();
                        ConsultarPrestamos();
                        idPrestamoSeleccionado = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dgvPrestamos.Rows[e.RowIndex];

                idPrestamoSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtUsuario.Text = fila.Cells[1].Value.ToString();
                txtLibro.Text = fila.Cells[2].Value.ToString();
                cbeEstatus.Text = fila.Cells[5].Value.ToString();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ConsultarPrestamos(txtBusqueda.Text);
        }

        private void Limpiar()
        {
            txtUsuario.Clear();
            txtLibro.Clear();
            cbeEstatus.SelectedIndex = -1;
        }
    }
}