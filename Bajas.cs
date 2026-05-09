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
        SqlConnection con = new SqlConnection("Server=localhost;Database=Gestión para Sala de Lectura;Integrated Security=true");

        public Bajas()
        {
            InitializeComponent();
            MostrarBajas();
            CargarMotivos();
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
            if (string.IsNullOrEmpty(txtLibro.Text))
            {
                MessageBox.Show("Escribe el nombre del libro");
                return;
            }

            try
            {
                con.Open();

                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    string queryID = "SELECT Libros_ID FROM Libros WHERE Titulo = @Titulo";
                    SqlCommand cmdID = new SqlCommand(queryID, con, trans);
                    cmdID.Parameters.AddWithValue("@Titulo", txtLibro.Text);

                    object result = cmdID.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Libro no encontrado");
                        trans.Rollback();
                        con.Close();
                        return;
                    }

                    int libroID = Convert.ToInt32(result);

                    string insertBaja = @"INSERT INTO BajaLibros (Fecha, Motivo, Libros_ID, Bibliotecario_ID)
                                  VALUES (@Fecha, @Motivo, @LibroID, 1)";

                    SqlCommand cmdInsert = new SqlCommand(insertBaja, con, trans);
                    cmdInsert.Parameters.AddWithValue("@Fecha", dtpFecha.Value);
                    cmdInsert.Parameters.AddWithValue("@Motivo", cbeMotivo.Text);
                    cmdInsert.Parameters.AddWithValue("@LibroID", libroID);

                    cmdInsert.ExecuteNonQuery();

                    string deleteLibro = "UPDATE Libros SET Estatus_Operativo = 'Baja' WHERE Titulo = @Titulo";
                    SqlCommand cmdDelete = new SqlCommand(deleteLibro, con, trans);
                    cmdDelete.Parameters.AddWithValue("@Titulo", txtLibro.Text);

                    cmdDelete.ExecuteNonQuery();

                    trans.Commit();
                    con.Close();

                    MessageBox.Show("Libro dado de baja correctamente");

                    MostrarBajas();
                }
                catch (Exception ex2)
                {
                    trans.Rollback();
                    con.Close();
                    MessageBox.Show("Error en transacción: " + ex2.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                con.Close();
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
                                 WHERE L.Titulo LIKE @Busqueda";

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
    }
}