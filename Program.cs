using System;
using System.Windows.Forms;

namespace Vagabunda
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.ThreadException += (s, e) =>
            {
                MessageBox.Show(
                    e.Exception.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            };

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                MessageBox.Show(
                    e.ExceptionObject.ToString(),
                    "Error Fatal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            };

            try
            {
                DevExpress.Skins.SkinManager.EnableFormSkins();

                Application.Run(new IniciarSesion());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error de Diagnóstico:\n\n" + ex.ToString(),
                    "Error de Arranque - Vagabunda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}