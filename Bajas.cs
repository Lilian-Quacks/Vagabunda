using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Vagabunda
{
    public partial class Bajas : Form
    {
        string cadena = @"Data Source=LOCALHOST;Initial Catalog=Gestión para Sala de Lectura;Integrated Security=True;";
        SqlConnection con;


        public Bajas()
        {
            InitializeComponent();

            con = new SqlConnection(cadena);

            MostrarBajas();
            CargarMotivos();

            cbeMotivo.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Today;
        }

        void MostrarBajas()
        {
            try
            {
                con.Open();

                string query = @"SELECT B.Baja_ID, L.Titulo, B.Motivo, B.Fecha
                                 FROM BajaLibros B
                                 INNER JOIN Libros L ON B.Libros_ID = L.Libros_ID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBajas.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgvBajas.Rows.Add(
                        row["Baja_ID"],
                        row["Titulo"],
                        row["Motivo"],
                        Convert.ToDateTime(row["Fecha"]).ToShortDateString()
                    );
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
            }
        }

        void CargarMotivos()
        {
            cbeMotivo.Items.Add("Dañado");
            cbeMotivo.Items.Add("Perdido");
            cbeMotivo.Items.Add("Obsoleto");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibro.Text) || cbeMotivo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un libro y el motivo de la baja.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de dar de baja este libro? No aparecerá más para préstamos.",
                "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No) return;

            try
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    string queryValidar = "SELECT Libros_ID, Estatus_Operativo FROM Libros WHERE ISBN = @isbn";
                    SqlCommand cmdValidar = new SqlCommand(queryValidar, con, trans);
                    cmdValidar.Parameters.AddWithValue("@isbn", txtLibro.Text.Trim());

                    int libroID = 0;
                    string estatusActual = "";

                    using (SqlDataReader reader = cmdValidar.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            libroID = Convert.ToInt32(reader["Libros_ID"]);
                            estatusActual = reader["Estatus_Operativo"].ToString();
                        }
                    }

                    if (libroID == 0)
                    {
                        MessageBox.Show("Libro no encontrado.");
                        trans.Rollback();
                        con.Close();
                        return;
                    }

                    if (estatusActual == "Baja")
                    {
                        MessageBox.Show("Este libro ya fue dado de baja anteriormente.");
                        trans.Rollback();
                        con.Close();
                        return;
                    }

                    if (estatusActual == "Prestado")
                    {
                        MessageBox.Show("No se puede dar de baja un libro que está actualmente prestado. Debe esperar a su devolución.");
                        trans.Rollback();
                        con.Close();
                        return;
                    }

                    string insertBaja = @"INSERT INTO BajaLibros (Fecha, Motivo, Libros_ID, Bibliotecario_ID)
                                  VALUES (@Fecha, @Motivo, @LibroID, (SELECT TOP 1 Bibliotecario_ID FROM Bibliotecario))";

                    SqlCommand cmdInsert = new SqlCommand(insertBaja, con, trans);
                    cmdInsert.Parameters.AddWithValue("@Fecha", dtpFecha.Value);
                    cmdInsert.Parameters.AddWithValue("@Motivo", cbeMotivo.Text);
                    cmdInsert.Parameters.AddWithValue("@LibroID", libroID);
                    cmdInsert.ExecuteNonQuery();

                    string updateLibro = "UPDATE Libros SET Estatus_Operativo = 'Baja' WHERE Libros_ID = @LibroID";
                    SqlCommand cmdUpdate = new SqlCommand(updateLibro, con, trans);
                    cmdUpdate.Parameters.AddWithValue("@LibroID", libroID);
                    cmdUpdate.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show("El libro ha sido dado de baja exitosamente.");

                    txtLibro.Clear();
                }
                catch (Exception ex2)
                {
                    trans.Rollback();
                    MessageBox.Show("Error en el proceso de baja: " + ex2.Message);
                }
                finally
                {
                    con.Close();
                    MostrarBajas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }


        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = @"SELECT B.Baja_ID, L.Titulo, B.Motivo, B.Fecha
                 FROM BajaLibros B
                 INNER JOIN Libros L ON B.Libros_ID = L.Libros_ID
                 WHERE L.Titulo LIKE @Busqueda
                 ORDER BY B.Fecha DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Busqueda", "%" + txtBusqueda.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBajas.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    dgvBajas.Rows.Add(
                        row["Baja_ID"],
                        row["Titulo"],
                        row["Motivo"],
                        Convert.ToDateTime(row["Fecha"]).ToShortDateString()
                    );
                }

                con.Close();
            }
            catch
            {
                con.Close();
            }
        }

        private void txtLibro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                InfoLiibros ver = new InfoLiibros();
                if (ver.ShowDialog() == DialogResult.OK)
                {
                    BuscarLibroPorCodigo(ver.IsbnSeleccionado);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                BuscarLibroPorCodigo(txtLibro.Text.Trim());
            }
        }

        private void BuscarLibroPorCodigo(string isbn)
        {
            using (SqlConnection con = new SqlConnection(cadena))
            {
                string query = "SELECT ISBN, Titulo FROM Libros WHERE ISBN = @dato";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dato", isbn);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtLibro.Text = dr["ISBN"].ToString();
                }
                else
                {
                    MessageBox.Show("Libro no encontrado.");
                }
            }
        }


    }
}