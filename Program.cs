using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectX
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                await DB.createDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к БД: {ex.Message}",
                                "Критическая ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return; // Завершаем работу, если база не создалась
            }

            Application.Run(new LoginForm());
        }
    }
}