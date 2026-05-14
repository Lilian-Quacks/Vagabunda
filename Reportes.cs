using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vagabunda
{
    public partial class Reportes : Form
    {
        string conexion = @"Data Source=LOCALHOST;Initial Catalog=Gestión para Sala de Lectura;Integrated Security=True;";

        public Reportes()
        {
            InitializeComponent();

            cbeReportes.Items.Add("Libros prestados");
            cbeReportes.Items.Add("Libros regresados");
            cbeReportes.Items.Add("Libros fuera de periodo de prestamo");
            cbeReportes.Items.Add("Titulos mas solicitados");

            cbeReportes.SelectedIndex = 0;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            dgvDatosPrestamos.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string query = "";

                switch (cbeReportes.Text)
                {
                    case "Libros prestados":

                        query = @"
                        SELECT 
                            P.Prestamo_ID,
                            U.Nombre AS Usuario,
                            L.Titulo AS Libro,
                            CONVERT(VARCHAR, P.Fecha_Salida, 103) AS Fecha,
                            ISNULL(CONVERT(VARCHAR, P.Penalizacion_Generada), '0') AS Penalizacion,
                            'PRESTADO' AS Motivo
                        FROM Prestamos P
                        INNER JOIN Usuarios U 
                            ON P.Usuario_ID = U.Usuario_ID
                        INNER JOIN Libros L 
                            ON P.Libros_ID = L.Libros_ID
                        WHERE MONTH(P.Fecha_Salida) = MONTH(GETDATE())
                        AND YEAR(P.Fecha_Salida) = YEAR(GETDATE())
                        ORDER BY P.Fecha_Salida DESC";

                        break;

                    case "Libros regresados":

                        query = @"
                        SELECT 
                            P.Prestamo_ID,
                            U.Nombre AS Usuario,
                            L.Titulo AS Libro,
                            CONVERT(VARCHAR, P.Fecha_Devolucion, 103) AS Fecha,
                            ISNULL(CONVERT(VARCHAR, P.Penalizacion_Generada), '0') AS Penalizacion,
                            'REGRESADO' AS Motivo
                        FROM Prestamos P
                        INNER JOIN Usuarios U 
                            ON P.Usuario_ID = U.Usuario_ID
                        INNER JOIN Libros L 
                            ON P.Libros_ID = L.Libros_ID
                        WHERE P.Estatus = 'Devuelto'
                        AND P.Fecha_Devolucion IS NOT NULL
                        AND MONTH(P.Fecha_Salida) = MONTH(GETDATE())
                        AND YEAR(P.Fecha_Salida) = YEAR(GETDATE())
                        ORDER BY P.Fecha_Devolucion DESC";

                        break;

                    case "Libros fuera de periodo de prestamo":

                        query = @"
                        SELECT 
                            P.Prestamo_ID,
                            U.Nombre AS Usuario,
                            L.Titulo AS Libro,
                            CONVERT(VARCHAR, P.Fecha_Limite, 103) AS Fecha,
                            ISNULL(CONVERT(VARCHAR, P.Penalizacion_Generada), '0') AS Penalizacion,
                            'FUERA DE TIEMPO' AS Motivo
                        FROM Prestamos P
                        INNER JOIN Usuarios U 
                            ON P.Usuario_ID = U.Usuario_ID
                        INNER JOIN Libros L 
                            ON P.Libros_ID = L.Libros_ID
                        WHERE GETDATE() > P.Fecha_Limite
                        AND P.Estatus = 'Prestado'
                        ORDER BY P.Fecha_Limite DESC";

                        break;

                    case "Titulos mas solicitados":

                        query = @"
                        SELECT TOP 20
                            L.Libros_ID,
                            'N/A' AS Usuario,
                            L.Titulo AS Libro,
                            CONVERT(VARCHAR, L.Contador_Prestamo) + ' prestamos' AS Fecha,
                            '0' AS Penalizacion,
                            'MAS SOLICITADO' AS Motivo
                        FROM Libros L
                        ORDER BY L.Contador_Prestamo DESC";

                        break;
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvDatosPrestamos.Rows.Add(
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString(),
                        dr[5].ToString()
                    );
                }
            }

           // label1.Text = cbeReportes.Text.ToUpper();
        }


        private void cbeReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}