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
    public partial class GestionDeUsuarios : Form
    {
        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Gestión para Sala de Lectura;Integrated Security=True;";

        int idUsuarioSeleccionado = 0;

        public GestionDeUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += GestionDeUsuarios_Load;
        }

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {
            if (cmbAdeudo.Properties.Items.Count == 0)
            {
                cmbAdeudo.Properties.Items.Add("0");
                cmbAdeudo.Properties.Items.Add("50");
                cmbAdeudo.Properties.Items.Add("100");
                cmbAdeudo.Properties.Items.Add("200");
            }

            ConsultarUsuarios();
        }

        private void ConsultarUsuarios(string filtro = "")
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    string query = @"SELECT Usuario_ID, Nombre, Telefono, Email, Adeudo_Pendiente, Prestamos_Activos 
                                     FROM Usuarios";

                    if (!string.IsNullOrEmpty(filtro))
                    {
                        query += " WHERE Nombre LIKE @filtro OR Email LIKE @filtro";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    if (!string.IsNullOrEmpty(filtro))
                        da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvUsuarios.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        dgvUsuarios.Rows.Add(
                            row["Usuario_ID"],
                            row["Nombre"],
                            row["Telefono"],
                            row["Email"],
                            row["Adeudo_Pendiente"],
                            row["Prestamos_Activos"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    string query = @"INSERT INTO Usuarios 
                                    (Nombre, Telefono, Email, Adeudo_Pendiente, Prestamos_Activos)
                                    VALUES (@nombre, @tel, @mail, @adeudo, 0)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@mail", txtCorreo.Text.Trim());

                    decimal adeudo = 0;
                    decimal.TryParse(cmbAdeudo.Text, out adeudo);
                    cmd.Parameters.AddWithValue("@adeudo", adeudo);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario guardado correctamente");

                    LimpiarCampos();
                    ConsultarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ConsultarUsuarios(txtBusqueda.Text);
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbAdeudo.SelectedIndex = -1;
        }
    }
}