using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vagabunda
{
    public partial class PerfilBibiotecario : Form
    {
        string cadena = @"Data Source=PERLARAMIREZ;Initial Catalog=Gestión para Sala de Lectura;User ID=sa;Password=Don32324;";

        public PerfilBibiotecario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Quitamos el ReadOnly para que puedas editarlo
            TXTUsuario.ReadOnly = false;
        }

        private void PerfilBibiotecario_Load(object sender, EventArgs e)
        {
            string usuarioActivo = Properties.Settings.Default.UsuarioGuardado;

            if (string.IsNullOrEmpty(usuarioActivo))
            {
                usuarioActivo = Microsoft.VisualBasic.Interaction.InputBox("Usuario no detectado. Ingresa tu nombre de usuario:", "Cargar Datos", "");
            }

            if (!string.IsNullOrEmpty(usuarioActivo))
            {
                CargarDatos(usuarioActivo);
            }
        }

        private void CargarDatos(string usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    string query = "SELECT Nombre, Usuario_Login, Rol, Correo, Contraseña FROM Bibliotecario WHERE Usuario_Login = @user";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@user", usuario.Trim());

                    conexion.Open();
                    SqlDataReader leer = comando.ExecuteReader();

                    if (leer.Read())
                    {
                        TXTNombre.Text = leer["Nombre"].ToString();
                        TXTUsuario.Text = leer["Usuario_Login"].ToString();
                        TXTRol.Text = leer["Rol"].ToString();
                        TXTCorreo.Text = leer["Correo"].ToString();
                        TXTContraAct.Text = leer["Contraseña"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void SB_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    string query = "UPDATE Bibliotecario SET Nombre=@nom, Rol=@rol, Correo=@mail, Usuario_Login=@nuevoUser WHERE Usuario_Login=@userOriginal";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nom", TXTNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@rol", TXTRol.Text.Trim());
                    comando.Parameters.AddWithValue("@mail", TXTCorreo.Text.Trim());
                    comando.Parameters.AddWithValue("@nuevoUser", TXTUsuario.Text.Trim());

                    comando.Parameters.AddWithValue("@userOriginal", Properties.Settings.Default.UsuarioGuardado);

                    conexion.Open();
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        Properties.Settings.Default.UsuarioGuardado = TXTUsuario.Text.Trim();
                        Properties.Settings.Default.Save();

                        MessageBox.Show("¡Perfil actualizado!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void SB_Contra_Click(object sender, EventArgs e)
        {
            if (TXTNuevaContra.Text == TXTConfNuevContra.Text && !string.IsNullOrEmpty(TXTNuevaContra.Text))
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        string query = "UPDATE Bibliotecario SET Contraseña=@nueva WHERE Usuario_Login=@user";
                        SqlCommand comando = new SqlCommand(query, conexion);

                        comando.Parameters.AddWithValue("@nueva", TXTNuevaContra.Text.Trim());
                        comando.Parameters.AddWithValue("@user", TXTUsuario.Text.Trim());

                        conexion.Open();
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Contraseña cambiada.");
                            TXTContraAct.Text = TXTNuevaContra.Text;
                            TXTNuevaContra.Clear();
                            TXTConfNuevContra.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }
        }
    }
}