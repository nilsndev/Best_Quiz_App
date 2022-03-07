using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Best_Quiz_App
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Best_Quiz_App.Forms.MainForm());
        }
    }
}
