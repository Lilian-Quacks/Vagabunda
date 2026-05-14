using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vagabunda
{
    public partial class InfoUsuarios : Form
    {
        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Gestión para Sala de Lectura;Integrated Security=True;";
        public string NombreSeleccionado { get; set; }

        public InfoUsuarios()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvInfo2.Columns.Clear();
            dgvInfo2.Columns.Add("id", "ID");
            dgvInfo2.Columns.Add("nombre", "NOMBRE");
            dgvInfo2.Columns.Add("tel", "TELÉFONO");
            dgvInfo2.Columns.Add("mail", "CORREO");

            dgvInfo2.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            dgvInfo2.ColumnHeadersDefaultCellStyle.BackColor;

            dgvInfo2.RowHeadersDefaultCellStyle.SelectionBackColor =
            dgvInfo2.RowHeadersDefaultCellStyle.BackColor;
        }

        private void InfoUsuarios_Load(object sender, EventArgs e)
        {
            Consultar(txtBusqueda.Text);
            if (dgvInfo2.Columns.Count > 0) dgvInfo2.Columns[0].Visible = false;
        }

        private void Consultar(string f)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string q = "SELECT Usuario_ID, Nombre, Telefono, Email FROM Usuarios";
                if (!string.IsNullOrEmpty(f)) q += " WHERE Nombre LIKE @f OR Telefono LIKE @f OR Email LIKE @f";

                SqlDataAdapter da = new SqlDataAdapter(q, con);
                da.SelectCommand.Parameters.AddWithValue("@f", "%" + f + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInfo2.Rows.Clear();
                foreach (DataRow dr in dt.Rows) dgvInfo2.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e) => Consultar(txtBusqueda.Text);

        private void dgvInfo2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.NombreSeleccionado = dgvInfo2.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}