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
using System.Text.RegularExpressions;

namespace Vagabunda
{
    public partial class GestionDeUsuarios : Form
    {
        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Gestión para Sala de Lectura;Integrated Security=True;";
        int idSeleccionado = -1;

        public GestionDeUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor;

            dgvUsuarios.RowHeadersDefaultCellStyle.SelectionBackColor =
            dgvUsuarios.RowHeadersDefaultCellStyle.BackColor;
        }

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {
            ConsultarUsuarios();
            if (dgvUsuarios.Columns.Count > 0)
                dgvUsuarios.Columns[0].Visible = false;
        }

        private bool ValidarCorreo(string email)
        {
            string expresion = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, expresion);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, llena los campos de detalles.");
                return;
            }

            if (!ValidarCorreo(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadena))
                {
                    con.Open();

                    string verificar = @"SELECT COUNT(*) FROM Usuarios WHERE (Telefono=@tel OR Email=@mail) AND Usuario_ID != @id";
                    SqlCommand validar = new SqlCommand(verificar, con);
                    validar.Parameters.AddWithValue("@tel", txtTelefono.Text.Trim());
                    validar.Parameters.AddWithValue("@mail", txtCorreo.Text.Trim());
                    validar.Parameters.AddWithValue("@id", idSeleccionado);

                    int existe = Convert.ToInt32(validar.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show("El teléfono o correo ya pertenecen a otro usuario.");
                        return;
                    }

                    string query = "";
                    if (idSeleccionado == -1) 
                    {
                        query = @"INSERT INTO Usuarios (Nombre, Direccion, Telefono, Email, Adeudo_Pendiente, Prestamos_Activos) 
                                 VALUES (@nombre, @direccion, @tel, @mail, 0, 0)";
                    }
                    else 
                    {
                        query = @"UPDATE Usuarios SET Nombre=@nombre, Direccion=@direccion, Telefono=@tel, Email=@mail 
                                 WHERE Usuario_ID=@id";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@tel", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@mail", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(idSeleccionado == -1 ? "Usuario guardado" : "Usuario actualizado");

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
                    if (!string.IsNullOrEmpty(filtro))
                        query += " WHERE Nombre LIKE @filtro OR Email LIKE @filtro OR Telefono LIKE @filtro";

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

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtDireccion.Text = fila.Cells[2].Value.ToString();
                txtTelefono.Text = fila.Cells[3].Value.ToString();
                txtCorreo.Text = fila.Cells[4].Value.ToString();

                MessageBox.Show("Modo edición activado para el usuario: " + txtNombre.Text);
            }
        }

        private void LimpiarCamposDetalle()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombre.ReadOnly = false;
            idSeleccionado = -1;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ConsultarUsuarios(txtBusqueda.Text.Trim());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposDetalle();
        }
    }
}