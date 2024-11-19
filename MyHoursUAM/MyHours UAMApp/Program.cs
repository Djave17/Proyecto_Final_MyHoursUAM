using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHours_UAMApp
{

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el splash screen
            using (var splashScreen = new SplashScreen())
            {
                splashScreen.ShowDialog();
            }

            // Iniciar la aplicación principal
            Application.Run(new Rol()); // Asegúrate de que 'MainForm' es el nombre de tu formulario principal
        }
    }
}
