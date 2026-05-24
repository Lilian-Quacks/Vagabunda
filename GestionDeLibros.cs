using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Vagabunda
{
    public partial class GestionDeLibros : Form
    {
        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Gestión para Sala de Lectura;Integrated Security=True;";
        int idLibroSeleccionado = -1;

        public GestionDeLibros()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvLibros.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            dgvLibros.ColumnHeadersDefaultCellStyle.BackColor;

            dgvLibros.RowHeadersDefaultCellStyle.SelectionBackColor =
            dgvLibros.RowHeadersDefaultCellStyle.BackColor;
        }

        private void GestionDeLibros_Load(object sender, EventArgs e)
        {
            dtpFechaPublicacion.Value = DateTime.Now;
            if (cbeEstadoFisico.Items.Count == 0)
            {
                cbeEstadoFisico.Items.Add("Nuevo");
                cbeEstadoFisico.Items.Add("Buen Estado");
                cbeEstadoFisico.Items.Add("Dañado");
                cbeEstadoFisico.Items.Add("Restauración");
            }

            if (cbeEstadoFisico.Items.Count > 0) cbeEstadoFisico.SelectedIndex = 0;

            ConsultarLibros();

            if (dgvLibros.Columns.Count > 0) dgvLibros.Columns[0].Visible = false;
        }

        private void ConsultarLibros(string filtro = "")
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    string query = "SELECT Libros_ID, ISBN, Titulo, Autor, Editorial, Estado_Fisico, Fecha_Publicacion " +
                                   "FROM Libros WHERE Estatus_Operativo != 'Baja'";

                    if (!string.IsNullOrEmpty(filtro))
                    {
                        query += " AND (Titulo LIKE @filtro OR Autor LIKE @filtro OR ISBN LIKE @filtro)";
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                    if (!string.IsNullOrEmpty(filtro))
                        adapter.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvLibros.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvLibros.Rows.Add(
                            row["Libros_ID"],
                            row["ISBN"],
                            row["Titulo"],
                            row["Autor"],
                            row["Editorial"],
                            row["Estado_Fisico"],
                            Convert.ToDateTime(row["Fecha_Publicacion"]).ToShortDateString()
                        );
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar libros: " + ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) || string.IsNullOrWhiteSpace(txtEditorial.Text) ||
                string.IsNullOrWhiteSpace(cbeEstadoFisico.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idLibroSeleccionado != -1)
            {
                DialogResult confirmacion = MessageBox.Show("¿Desea confirmar la modificación de este libro?", "Validar Cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "";

                    if (idLibroSeleccionado == -1)
                    {
                        query = @"INSERT INTO Libros (ISBN, Titulo, Autor, Editorial, Fecha_Publicacion, Estado_Fisico, Estatus_Operativo) 
                                 VALUES (@isbn, @titulo, @autor, @editorial, @fecha, @estado, 'Disponible')";
                    }
                    else 
                    {
                        query = @"UPDATE Libros SET ISBN=@isbn, Titulo=@titulo, Autor=@autor, Editorial=@editorial, 
                                 Fecha_Publicacion=@fecha, Estado_Fisico=@estado WHERE Libros_ID=@id";
                    }

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@isbn", txtCodigo.Text.Trim());
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());
                    cmd.Parameters.AddWithValue("@autor", txtAutor.Text.Trim());
                    cmd.Parameters.AddWithValue("@editorial", txtEditorial.Text.Trim());
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaPublicacion.Value);
                    cmd.Parameters.AddWithValue("@estado", cbeEstadoFisico.Text);
                    cmd.Parameters.AddWithValue("@id", idLibroSeleccionado);

                    cmd.ExecuteNonQuery();

                    string mensaje = (idLibroSeleccionado == -1) ? "Libro registrado." : "Modificación exitosa.";
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    ConsultarLibros();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
                idLibroSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtCodigo.Text = fila.Cells[1].Value.ToString();
                txtTitulo.Text = fila.Cells[2].Value.ToString();
                txtAutor.Text = fila.Cells[3].Value.ToString();
                txtEditorial.Text = fila.Cells[4].Value.ToString();
                cbeEstadoFisico.Text = fila.Cells[5].Value.ToString();
                dtpFechaPublicacion.Value = Convert.ToDateTime(fila.Cells[6].Value);
                txtTitulo.ReadOnly = false;
                txtCodigo.SelectionStart = txtCodigo.Text.Length;
                txtTitulo.SelectionStart = txtTitulo.Text.Length;
                txtAutor.SelectionStart = txtAutor.Text.Length;
                txtEditorial.SelectionStart = txtEditorial.Text.Length;
            }
        }



        private void txtBusquedaDeLibros_TextChanged(object sender, EventArgs e)
        {
            ConsultarLibros(txtBusquedaDeLibros.Text.Trim());
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            txtTitulo.ReadOnly = false;
            cbeEstadoFisico.SelectedIndex = 0;
            dtpFechaPublicacion.Value = DateTime.Now;
            idLibroSeleccionado = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}