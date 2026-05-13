using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vagabunda
{
    public partial class GestionDeLibros : Form
    {
        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Vagabunda;Integrated Security=True;";

        public GestionDeLibros()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void GestionDeLibros_Load(object sender, EventArgs e)
        {
            if (cbeEstadoFisico.Items.Count == 0)
            {
                cbeEstadoFisico.Items.Add("Nuevo");
                cbeEstadoFisico.Items.Add("Buen Estado");
                cbeEstadoFisico.Items.Add("Dañado");
                cbeEstadoFisico.Items.Add("Restauración");
            }

            ConsultarLibros();
        }

        private void ConsultarLibros(string filtro = "")
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    string query = "SELECT Libros_ID, ISBN, Titulo, Autor, Editorial, Estado_Fisico, Fecha_Publicacion " +
                           "FROM Libros WHERE Estatus_Operativo != 'BAJA'";

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
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                    string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                    string.IsNullOrWhiteSpace(txtAutor.Text) ||
                    string.IsNullOrWhiteSpace(txtEditorial.Text) ||
                    string.IsNullOrWhiteSpace(cbeEstadoFisico.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios. Por favor, completa la información.",
                                    "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        string query = @"INSERT INTO Libros (ISBN, Titulo, Autor, Editorial, Fecha_Publicacion, Estado_Fisico, Estatus_Operativo) 
                                    VALUES (@isbn, @titulo, @autor, @editorial, @fecha, @estado, 'Disponible')";

                        SqlCommand cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@isbn", txtCodigo.Text.Trim());
                        cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());
                        cmd.Parameters.AddWithValue("@autor", txtAutor.Text.Trim());
                        cmd.Parameters.AddWithValue("@editorial", txtEditorial.Text.Trim());
                        cmd.Parameters.AddWithValue("@fecha", dtpFechaPublicacion.Value);
                        cmd.Parameters.AddWithValue("@estado", cbeEstadoFisico.Text);

                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Libro registrado con éxito.");
                        LimpiarCampos();
                        ConsultarLibros();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        private void txtBusquedaDeLibros_TextChanged(object sender, EventArgs e)
        {
            ConsultarLibros(txtBusquedaDeLibros.Text);
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            cbeEstadoFisico.SelectedIndex = -1;
            dtpFechaPublicacion.Value = DateTime.Now;
        }
    }
}