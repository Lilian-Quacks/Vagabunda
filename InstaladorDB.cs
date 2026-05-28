using System;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace Vagabunda
{
    [RunInstaller(true)]
    public class InstaladorBD : Installer
    {
        private Container components = null;

        public InstaladorBD()
        {
            components = new Container();
        }

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);

            try
            {
                string rutaDirectorio = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                string rutaScript = Path.Combine(rutaDirectorio, "Vagabunda.sql");

                if (!File.Exists(rutaScript))
                {
                    throw new InstallException("No se encontró el archivo de script SQL.");
                }

                string contenidoScript = File.ReadAllText(rutaScript);
                string cadenaConexion = "Data Source=.;Initial Catalog=master;Integrated Security=True;";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string[] comandos = contenidoScript.Split(new[] { "GO", "go", "Go", "gO" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string comandoTexto in comandos)
                    {
                        string comandoLimpio = comandoTexto.Trim();
                        if (!string.IsNullOrEmpty(comandoLimpio))
                        {
                            using (SqlCommand cmd = new SqlCommand(comandoLimpio, conexion))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al inicializar la base de datos: " + ex.Message, "Error de Instalación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new InstallException(ex.Message);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}