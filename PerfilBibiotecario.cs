using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vagabunda
{
    public partial class PerfilBibiotecario : Form
    {
        string cadena = @"Data Source=.;Initial Catalog=Vagabunda;Integrated Security=True;";

        public PerfilBibiotecario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            else
            {
                MessageBox.Show("No se proporcionó ningún usuario. El formulario no mostrará información.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    else
                    {
                        MessageBox.Show("No se encontraron datos para el usuario especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SB_Actualizar_Click(object sender, EventArgs e)
        {
            // 1. Validación estricta de campos vacíos
            if (string.IsNullOrWhiteSpace(TXTNombre.Text) ||
                string.IsNullOrWhiteSpace(TXTRol.Text) ||
                string.IsNullOrWhiteSpace(TXTCorreo.Text) ||
                string.IsNullOrWhiteSpace(TXTUsuario.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos de perfil. No puedes dejar datos vacíos.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene el flujo del programa
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    string usuarioOriginal = Properties.Settings.Default.UsuarioGuardado;

                    if (string.IsNullOrEmpty(usuarioOriginal))
                    {
                        MessageBox.Show("Error de sesión: No se puede identificar al usuario original para actualizar.", "Error de Identidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "UPDATE Bibliotecario SET Nombre=@nom, Rol=@rol, Correo=@mail, Usuario_Login=@nuevoUser WHERE Usuario_Login=@userOriginal";
                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nom", TXTNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@rol", TXTRol.Text.Trim());
                    comando.Parameters.AddWithValue("@mail", TXTCorreo.Text.Trim());
                    comando.Parameters.AddWithValue("@nuevoUser", TXTUsuario.Text.Trim());
                    comando.Parameters.AddWithValue("@userOriginal", usuarioOriginal);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {                     
                        Properties.Settings.Default.UsuarioGuardado = TXTUsuario.Text.Trim();
                        Properties.Settings.Default.Save();

                        MessageBox.Show("¡Perfil actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro. Es posible que el usuario haya sido modificado externamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos en el servidor: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SB_Contra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTNuevaContra.Text) || string.IsNullOrWhiteSpace(TXTConfNuevContra.Text))
            {
                MessageBox.Show("Los campos de la nueva contraseña no pueden quedar vacíos o contener solo espacios.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene el flujo del programa
            }
                        
            if (TXTNuevaContra.Text == TXTConfNuevContra.Text)
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(cadena))
                    {
                        string query = "UPDATE Bibliotecario SET Contraseña=@nueva WHERE Usuario_Login=@user";
                        SqlCommand comando = new SqlCommand(query, conexion);

                        comando.Parameters.AddWithValue("@nueva", TXTNuevaContra.Text.Trim());
                        // Usamos de forma directa el TextBox del usuario que está cargado en pantalla
                        comando.Parameters.AddWithValue("@user", TXTUsuario.Text.Trim());

                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Contraseña cambiada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            TXTContraAct.Text = TXTNuevaContra.Text;
                            TXTNuevaContra.Clear();
                            TXTConfNuevContra.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario en la base de datos para realizar el cambio.", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la base de datos al cambiar la contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden. Por favor, revísalas.", "Error de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }
    }
}