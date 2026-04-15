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
    }
}
