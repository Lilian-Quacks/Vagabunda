using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Vagabunda
{
    public partial class MenuPrincipla : Form
    {
        public MenuPrincipla()
        {
            InitializeComponent();
            AsignarEventos();
        }

        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Gestión para Sala de Lectura;Integrated Security=True;";

        private void AsignarEventos()
        {
            LBLUSUARIOS.MouseEnter += LBLUSUARIOS_MouseEnter;
            LBLUSUARIOS.MouseLeave += LBLUSUARIOS_MouseLeave;
            LBLUSUARIOS.Click += LBLUSUARIOS_Click;

            LBLLIBROS.MouseEnter += LBLLIBROS_MouseEnter;
            LBLLIBROS.MouseLeave += LBLLIBROS_MouseLeave;
            LBLLIBROS.Click += LBLLIBROS_Click;

            LBLPRESTAMOS.MouseEnter += LBLPRESTAMOS_MouseEnter;
            LBLPRESTAMOS.MouseLeave += LBLPRESTAMOS_MouseLeave;
            LBLPRESTAMOS.Click += LBLPRESTAMOS_Click;

            LBLBAJAS.MouseEnter += LBLBAJAS_MouseEnter;
            LBLBAJAS.MouseLeave += LBLBAJAS_MouseLeave;
            LBLBAJAS.Click += LBLBAJAS_Click;

            LBLREPORTES.MouseEnter += LBLREPORTES_MouseEnter;
            LBLREPORTES.MouseLeave += LBLREPORTES_MouseLeave;
            LBLREPORTES.Click += LBLREPORTES_Click;

            LBLPerfil.MouseEnter += LBLPerfil_MouseEnter;
            LBLPerfil.MouseLeave += LBLPerfil_MouseLeave;
            LBLPerfil.Click += LBLPerfil_Click;
        }

        public void abrirFormPanel(object formHijo)
        {
            if (this.PNLPrograma.Controls.Count > 0)
            {
                this.PNLPrograma.Controls.Clear();
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PNLPrograma.Controls.Add(fh);
            this.PNLPrograma.Tag = fh;
            fh.Show();
        }

        private void LBLPerfil_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new PerfilBibiotecario());
        }

        private void LBLBAJAS_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new Bajas());
        }

        private void LBLREPORTES_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new Reportes());
        }

        private void LBLPRESTAMOS_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new GestioDePrestamos());
        }

        private void LBLUSUARIOS_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new GestionDeUsuarios());
        }

        private void LBLLIBROS_Click(object sender, EventArgs e)
        {
            abrirFormPanel(new GestionDeLibros());
        }

        private void BordesRedondos(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

        private async void MenuPrincipla_Load(object sender, EventArgs e)
        {
            BordesRedondos(panel1, 30);
            timer1.Start();

            _ = Task.Run(() => VerificarPrestamosRetrasados());
        }

        private void LBLUSUARIOS_MouseEnter(object sender, EventArgs e)
        {
            LBLUSUARIOS.BackColor = Color.Teal;
            Cursor = Cursors.Hand;
            LBLUSUARIOS.ForeColor = Color.OldLace;
        }

        private void LBLUSUARIOS_MouseLeave(object sender, EventArgs e)
        {
            LBLUSUARIOS.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
            LBLUSUARIOS.ForeColor = Color.Black;
        }

        private void LBLLIBROS_MouseEnter(object sender, EventArgs e)
        {
            LBLLIBROS.BackColor = Color.Teal;
            Cursor = Cursors.Hand;
            LBLLIBROS.ForeColor = Color.OldLace;
        }

        private void LBLLIBROS_MouseLeave(object sender, EventArgs e)
        {
            LBLLIBROS.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
            LBLLIBROS.ForeColor = Color.Black;
        }

        private void LBLPRESTAMOS_MouseEnter(object sender, EventArgs e)
        {
            LBLPRESTAMOS.BackColor = Color.Teal;
            Cursor = Cursors.Hand;
            LBLPRESTAMOS.ForeColor = Color.OldLace;
        }

        private void LBLPRESTAMOS_MouseLeave(object sender, EventArgs e)
        {
            LBLPRESTAMOS.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
            LBLPRESTAMOS.ForeColor = Color.Black;
        }

        private void LBLBAJAS_MouseEnter(object sender, EventArgs e)
        {
            LBLBAJAS.BackColor = Color.Teal;
            Cursor = Cursors.Hand;
            LBLBAJAS.ForeColor = Color.OldLace;
        }

        private void LBLBAJAS_MouseLeave(object sender, EventArgs e)
        {
            LBLBAJAS.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
            LBLBAJAS.ForeColor = Color.Black;
        }

        private void LBLREPORTES_MouseEnter(object sender, EventArgs e)
        {
            LBLREPORTES.BackColor = Color.Teal;
            Cursor = Cursors.Hand;
            LBLREPORTES.ForeColor = Color.OldLace;
        }

        private void LBLREPORTES_MouseLeave(object sender, EventArgs e)
        {
            LBLREPORTES.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
            LBLREPORTES.ForeColor = Color.Black;
        }

        private void LBLPerfil_MouseEnter(object sender, EventArgs e)
        {
            LBLPerfil.BackColor = Color.Teal;
            Cursor = Cursors.Hand;
            LBLPerfil.ForeColor = Color.OldLace;
        }

        private void LBLPerfil_MouseLeave(object sender, EventArgs e)
        {
            LBLPerfil.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
            LBLPerfil.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBLTIEMPO1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            string fecha = DateTime.Now.ToString("dddd dd MMMM yyyy");
            LBLFECHAA.Text = char.ToUpper(fecha[0]) + fecha.Substring(1);
        }

        private void panelPrograma_Paint(object sender, PaintEventArgs e)
        {
        }

        private void VerificarPrestamosRetrasados()
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                con.Open();

                string query = @"
        SELECT 
            p.Prestamo_ID,
            p.Fecha_Limite,
            p.Usuario_ID,
            p.Penalizacion_Generada,
            p.Estatus,
            u.Nombre,
            u.Email,
            l.Titulo
        FROM Prestamos p
        INNER JOIN Usuarios u ON p.Usuario_ID = u.Usuario_ID
        INNER JOIN Libros l ON p.Libros_ID = l.Libros_ID
        WHERE 
        (
            p.Estatus = 'Activo'
            OR p.Estatus = 'Retrasado'
        )
        AND p.Fecha_Devolucion IS NULL
        AND CAST(GETDATE() AS DATE) > CAST(p.Fecha_Limite AS DATE)";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();

                List<dynamic> prestamos = new List<dynamic>();

                while (dr.Read())
                {
                    prestamos.Add(new
                    {
                        PrestamoID = Convert.ToInt32(dr["Prestamo_ID"]),
                        FechaLimite = Convert.ToDateTime(dr["Fecha_Limite"]),
                        UsuarioID = Convert.ToInt32(dr["Usuario_ID"]),
                        PenalizacionActual = Convert.ToDecimal(dr["Penalizacion_Generada"]),
                        Estatus = dr["Estatus"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Email = dr["Email"].ToString(),
                        Libro = dr["Titulo"].ToString()
                    });
                }

                dr.Close();

                foreach (var p in prestamos)
                {
                    int diasRetraso =
                        (DateTime.Now.Date - p.FechaLimite.Date).Days;

                    // 1 al día siguiente
                    // luego cada 7 días
                    int semanas = ((diasRetraso - 1) / 7) + 1;

                    decimal multaEsperada = semanas * 50;

                    // ya tiene esa multa
                    if (multaEsperada <= p.PenalizacionActual)
                        continue;

                    decimal diferencia =
                        multaEsperada - p.PenalizacionActual;

                    SqlTransaction trans = con.BeginTransaction();

                    try
                    {
                        SqlCommand cmdUpdate = new SqlCommand(@"
                UPDATE Prestamos
                SET 
                    Estatus = 'Retrasado',
                    Penalizacion_Generada = @multa
                WHERE Prestamo_ID = @id",
                        con, trans);

                        cmdUpdate.Parameters.AddWithValue(
                            "@multa",
                            multaEsperada);

                        cmdUpdate.Parameters.AddWithValue(
                            "@id",
                            p.PrestamoID);

                        cmdUpdate.ExecuteNonQuery();

                        SqlCommand cmdAdeudo = new SqlCommand(@"
                UPDATE Usuarios
                SET Adeudo_Pendiente =
                    ISNULL(Adeudo_Pendiente,0) + @diferencia
                WHERE Usuario_ID = @uid",
                        con, trans);

                        cmdAdeudo.Parameters.AddWithValue(
                            "@diferencia",
                            diferencia);

                        cmdAdeudo.Parameters.AddWithValue(
                            "@uid",
                            p.UsuarioID);

                        cmdAdeudo.ExecuteNonQuery();

                        SqlCommand cmdPenal = new SqlCommand(@"
                INSERT INTO Penalizacion
                (
                    Fecha_Generada,
                    Monto,
                    Pagado,
                    Prestamo_ID
                )
                VALUES
                (
                    GETDATE(),
                    @multa,
                    0,
                    @prestamo
                )",
                        con, trans);

                        cmdPenal.Parameters.AddWithValue(
                            "@multa",
                            diferencia);

                        cmdPenal.Parameters.AddWithValue(
                            "@prestamo",
                            p.PrestamoID);

                        cmdPenal.ExecuteNonQuery();

                        trans.Commit();

                        MandandoMailRetraso(
                            p.Email,
                            p.Nombre,
                            p.Libro,
                            multaEsperada,
                            diasRetraso
                        );
                    }
                    catch
                    {
                        trans.Rollback();
                    }
                }
            }
        }

        private void MandandoMailRetraso( string receptor, string nombre, string libro, decimal multa, int dias)
        {
            try
            {
                MailMessage mensaje = new MailMessage();

                mensaje.From = new MailAddress("lilianramirez534@gmail.com");

                mensaje.To.Add(receptor);

                mensaje.Subject = "Aviso de retraso de préstamo - La Vagabunda";

                mensaje.Body =
                    "Hola " + nombre + ".\n\n" +
                    "El libro:\n" +
                    libro + "\n\n" +
                    "ha excedido la fecha límite de entrega.\n\n" +
                    "Días de retraso: " + dias + "\n" +
                    "Multa acumulada: $" + multa + " MXN\n\n" +
                    "Favor de acudir a biblioteca para regularizar la situación.";

                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");

                clienteSmtp.Port = 587;

                clienteSmtp.Credentials =
                    new NetworkCredential(
                        "lilianramirez534@gmail.com",
                        "udceftebesehwxos");

                clienteSmtp.EnableSsl = true;

                clienteSmtp.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error enviando correo: " +
                    (ex.InnerException?.Message ?? ex.Message));
            }
        }

    }
}