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

namespace Vagabunda
{
    public partial class MenuPrincipla : Form
    {
        public MenuPrincipla()
        {
            InitializeComponent();
            AsignarEventos();
        }

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
            if (this.panelPrograma.Controls.Count > 0)
            {
                this.panelPrograma.Controls.Clear();
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPrograma.Controls.Add(fh);
            this.panelPrograma.Tag = fh;
            fh.Show();
        }
        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void PE_Bibliotecario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void LBLPerfil_Click(object sender, EventArgs e)
        {
            PerfilBibiotecario perfil = new PerfilBibiotecario();
            perfil.ShowDialog();
        }

        private void LBLBAJAS_Click(object sender, EventArgs e)
        {
            Bajas bajas = new Bajas();
            bajas.ShowDialog();
        }

        private void LBLREPORTES_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
        }

        private void LBLPRESTAMOS_Click(object sender, EventArgs e)
        {
            GestioDePrestamos prestamos = new GestioDePrestamos();
            prestamos.Show();
        }

        private void LBLUSUARIOS_Click(object sender, EventArgs e)
        {
            GestionDeUsuarios usuarios = new GestionDeUsuarios();
            usuarios.Show();
        }

        private void LBLLIBROS_Click(object sender, EventArgs e)
        {
            GestionDeLibros libros = new GestionDeLibros();
            libros.Show();
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

        private void MenuPrincipla_Load(object sender, EventArgs e)
        {
            BordesRedondos(panel1, 30);
            timer1.Start();
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
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            string fecha = DateTime.Now.ToString("dddd dd MMMM yyyy");
            lblfecha.Text = char.ToUpper(fecha[0]) + fecha.Substring(1);
        }

        private void panelPrograma_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}