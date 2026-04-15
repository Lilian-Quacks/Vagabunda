using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Vagabunda
{
    public partial class IniciarSesion : Form
    {
        string cadena = @"Data Source=PERLARAMIREZ;Initial Catalog=Gestión para Sala de Lectura;User ID=sa;Password=Don32324;";

        public IniciarSesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LLOlvideContra.TabStop = false;
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.UsuarioGuardado))
            {
                TXTUsuario.Text = Properties.Settings.Default.UsuarioGuardado;
                TXTContra.Text = Properties.Settings.Default.ContraGuardada;
                CBRecordar.Checked = true;
            }
        }

        private void Sesion_Click(object sender, EventArgs e)
        {
            string usuario = TXTUsuario.Text.Trim();
            string contrasena = TXTContra.Text.Trim();

            if (ValidarUsuario(usuario, contrasena))
            {
                Properties.Settings.Default.UsuarioGuardado = usuario;
                Properties.Settings.Default.ContraGuardada = CBRecordar.Checked ? contrasena : "";
                Properties.Settings.Default.Save();

                MenuPrincipla seleccionar = new MenuPrincipla();

                // PASO 1: Le decimos que el inicio es en el centro de la pantalla
                seleccionar.StartPosition = FormStartPosition.CenterScreen;

                seleccionar.FormClosed += (s, args) => {
                    this.Show();
                    if (!CBRecordar.Checked) TXTContra.Clear();
                };

                // PASO 2: Mostramos el menú
                seleccionar.Show();

                // PASO 3: Re-centramos justo después de mostrarlo 
                // (Esto corrige el error de escalado de la laptop)
                seleccionar.Location = new Point(
                    Screen.PrimaryScreen.WorkingArea.Width / 2 - seleccionar.Width / 2,
                    Screen.PrimaryScreen.WorkingArea.Height / 2 - seleccionar.Height / 2
                );

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
        private bool ValidarUsuario(string user, string pass)
        {
            bool esValido = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    string query = "SELECT COUNT(*) FROM Bibliotecario WHERE Usuario_Login = @user AND Contraseña = @pass";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@user", user);
                    comando.Parameters.AddWithValue("@pass", pass);

                    conexion.Open();
                    int resultado = (int)comando.ExecuteScalar();
                    if (resultado > 0) esValido = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return esValido;
        }

        private void LLOlvideContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Contraseña pantallaRecuperar = new Contraseña();
            pantallaRecuperar.ShowDialog();
        }
    }
}