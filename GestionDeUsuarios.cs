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

        public GestionDeUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {
            CargarOpcionesAdeudo();
            ConsultarUsuarios();
        }

        private void CargarOpcionesAdeudo()
        {
            cmbAdeudo.Items.Clear();
            cmbAdeudo.Items.Add("ADEUDO");
            cmbAdeudo.Items.Add("0");
            cmbAdeudo.Items.Add("50");
            cmbAdeudo.Items.Add("100");
            cmbAdeudo.Items.Add("200");
            cmbAdeudo.SelectedIndex = 0;
        }

        private void cmbAdeudo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAdeudo.SelectedIndex > 0 && cmbAdeudo.Items.Contains("ADEUDO"))
            {
                string valorSeleccionado = cmbAdeudo.SelectedItem.ToString();
                cmbAdeudo.Items.RemoveAt(0);
                cmbAdeudo.Text = valorSeleccionado;
            }
        }

        private void dgvUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvUsuarios.EndEdit();
                ActualizarDesdeGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ActualizarDesdeGrid()
        {
            if (dgvUsuarios.CurrentRow == null) return;

            try
            {
                DataGridViewRow fila = dgvUsuarios.CurrentRow;

                int id = Convert.ToInt32(fila.Cells[0].Value);
                string nombre = fila.Cells[1].Value.ToString();
                string direccion = fila.Cells[2].Value.ToString();
                string telefono = fila.Cells[3].Value.ToString();
                string correo = fila.Cells[4].Value.ToString();
                decimal adeudo = Convert.ToDecimal(fila.Cells[5].Value);

                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    string query = @"UPDATE Usuarios SET Nombre=@nombre, Direccion=@direccion, Telefono=@tel, 
                                     Email=@mail, Adeudo_Pendiente=@adeudo WHERE Usuario_ID=@id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@tel", telefono);
                    cmd.Parameters.AddWithValue("@mail", correo);
                    cmd.Parameters.AddWithValue("@adeudo", adeudo);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsultarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                cmbAdeudo.Text == "ADEUDO")
            {
                MessageBox.Show("Por favor, llena los campos de detalles.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    string query = @"INSERT INTO Usuarios (Nombre, Direccion, Telefono, Email, Adeudo_Pendiente, Prestamos_Activos) 
                                     VALUES (@nombre, @direccion, @tel, @mail, @adeudo, 0)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@mail", txtCorreo.Text.Trim());

                    decimal montoAdeudo = 0;
                    decimal.TryParse(cmbAdeudo.Text, out montoAdeudo);
                    cmd.Parameters.AddWithValue("@adeudo", montoAdeudo);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario guardado");

                    LimpiarCamposDetalle();
                    ConsultarUsuarios();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        public void ConsultarUsuarios(string filtro = "")
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();
                    string query = "SELECT Usuario_ID, Nombre, Direccion, Telefono, Email, Adeudo_Pendiente, Prestamos_Activos FROM Usuarios";
                    if (!string.IsNullOrEmpty(filtro)) query += " WHERE Nombre LIKE @filtro OR Email LIKE @filtro";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    if (!string.IsNullOrEmpty(filtro)) da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvUsuarios.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvUsuarios.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void LimpiarCamposDetalle()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            CargarOpcionesAdeudo();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ConsultarUsuarios(txtBusqueda.Text.Trim());
        }
    }
}