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
    public partial class Reportes : Form
    {
        string conexion = @"Data Source=LOCALHOST;Initial Catalog=Gestión para Sala de Lectura;Integrated Security=True;";

        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
            CargarBajas();
        }

        private void CargarPrestamos()
        {
            dgvDatosPrestamos.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string query = @"
                SELECT 
                    P.Prestamo_ID,
                    U.Nombre AS Usuario,
                    ISNULL(L.Titulo, 'LIBRO ELIMINADO') AS Libro,
                    P.Estatus,
                    ISNULL(Pe.Monto, 0) AS Penalizacion,
                    ISNULL(B.Motivo, 'N/A') AS MotivoBaja
                FROM Prestamos P
                INNER JOIN Usuarios U ON P.Usuario_ID = U.Usuario_ID
                LEFT JOIN Libros L ON P.Libros_ID = L.Libros_ID
                LEFT JOIN Penalizacion Pe ON Pe.Prestamo_ID = P.Prestamo_ID
                LEFT JOIN BajaLibros B ON B.Libros_ID = P.Libros_ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvDatosPrestamos.Rows.Add(
                        dr["Prestamo_ID"],
                        dr["Usuario"],
                        dr["Libro"],
                        dr["Estatus"],
                        dr["Penalizacion"],
                        dr["MotivoBaja"]
                    );
                }
            }
        }

        private void CargarBajas()
        {
            dgvBajasLibros.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string query = @"
                SELECT 
                    ISNULL(L.Titulo, 'LIBRO ELIMINADO') AS Titulo,
                    'DADO DE BAJA' AS Estatus
                FROM BajaLibros B
                LEFT JOIN Libros L ON B.Libros_ID = L.Libros_ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvBajasLibros.Rows.Add(
                        dr["Titulo"],
                        dr["Estatus"]
                    );
                }
            }
        }
    }
}