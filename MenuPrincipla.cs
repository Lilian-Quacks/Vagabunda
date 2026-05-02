using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vagabunda
{
    public partial class MenuPrincipla : Form
    {
        public MenuPrincipla()
        {
            InitializeComponent();
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
    }
}
