using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Vagabunda
{
    public partial class Contraseña : Form
    {
        string cadena = @"Data Source=PERLARAMIREZ;Initial Catalog=Gestión para Sala de Lectura;User ID=sa;Password=Don32324;";

        public Contraseña()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SB_Enviar_Click(object sender, EventArgs e)
        {
            string correoABuscar = TXTCorreo.Text.Trim();

            if (string.IsNullOrEmpty(correoABuscar))
            {
                MessageBox.Show("Por favor, ingresa tu correo para buscar tus datos.");
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    string query = "SELECT Usuario_Login, Contraseña, Correo FROM Bibliotecario WHERE Correo = @mail";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@mail", correoABuscar);

                    conexion.Open();
                    SqlDataReader leer = comando.ExecuteReader();

                    if (leer.Read())
                    {
                        string usuarioBD = leer["Usuario_Login"].ToString();
                        string contraBD = leer["Contraseña"].ToString();
                        string correoDestino = leer["Correo"].ToString();

                        MandandoMail(correoDestino, usuarioBD, contraBD);
                    }
                    else
                    {
                        MessageBox.Show("El correo '" + correoABuscar + "' no está registrado en la tabla Bibliotecario.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
            }
        }

        private void MandandoMail(string receptor, string user, string pass)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("lilianramirez534@gmail.com");
                mensaje.To.Add(receptor);
                mensaje.Subject = "Recuperacion de Datos - La Vagabunda";
                mensaje.Body = "Hola, has solicitado recuperar tus datos.\n\nUsuario: " + user + "\nContraseña: " + pass;

                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
                clienteSmtp.Port = 587;

                clienteSmtp.Credentials = new NetworkCredential("lilianramirez534@gmail.com", "udceftebesehwxos");
                clienteSmtp.EnableSsl = true;

                clienteSmtp.Send(mensaje);

                MessageBox.Show("¡Listo! Los datos se enviaron a: " + receptor);
                this.Close();
            }
            catch (Exception ex)
            {  
                MessageBox.Show("Error detallado: " + ex.InnerException?.Message ?? ex.Message);
            }
        }
    }
}