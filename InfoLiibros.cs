using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vagabunda
{
    public partial class InfoLiibros : Form
    {
        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Vagabunda;Integrated Security=True;";
        public string IsbnSeleccionado { get; set; }

        public InfoLiibros()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvInfo.Columns.Clear();
            dgvInfo.Columns.Add("id", "ID");
            dgvInfo.Columns.Add("isbn", "ISBN");
            dgvInfo.Columns.Add("nombre", "NOMBRE");
            dgvInfo.Columns.Add("autor", "AUTOR");
            dgvInfo.Columns.Add("estatus", "ESTADO");

            dgvInfo.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            dgvInfo.ColumnHeadersDefaultCellStyle.BackColor;

            dgvInfo.RowHeadersDefaultCellStyle.SelectionBackColor =
            dgvInfo.RowHeadersDefaultCellStyle.BackColor;
        }

        private void InfoLiibros_Load(object sender, EventArgs e)
        {
            Consultar(txtBusqueda.Text);
            if (dgvInfo.Columns.Count > 0) dgvInfo.Columns["id"].Visible = false;
        }

        private void Consultar(string f)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string q = "SELECT Libros_ID, ISBN, Titulo, Autor, Estatus_Operativo FROM Libros WHERE Estatus_Operativo <> 'Baja'";

                if (!string.IsNullOrEmpty(f))
                    q += " AND (ISBN LIKE @f OR Titulo LIKE @f OR Autor LIKE @f)";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@f", "%" + f + "%");

                try
                {
                    con.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    dgvInfo.Rows.Clear();
                    while (r.Read())
                    {
                        dgvInfo.Rows.Add(r["Libros_ID"], r["ISBN"], r["Titulo"], r["Autor"], r["Estatus_Operativo"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar: " + ex.Message);
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e) => Consultar(txtBusqueda.Text);

        private void dgvInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string estatus = dgvInfo.Rows[e.RowIndex].Cells["estatus"].Value.ToString();

                if (estatus == "Prestado")
                {
                    MessageBox.Show("Este libro está prestado y no se puede seleccionar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.IsbnSeleccionado = dgvInfo.Rows[e.RowIndex].Cells["isbn"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}