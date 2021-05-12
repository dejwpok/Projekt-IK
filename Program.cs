using System;
using System.Windows.Forms;
using Projekt_IK.Formularze;

namespace Projekt_IK
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Panel_logowania());
        }
    }
}
