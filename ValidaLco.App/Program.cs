using System;
using System.Windows.Forms;
using ValidaLco.Negocios.Excepciones;

namespace ValidaLco.App
{
    static class Program
    {
     
        [STAThread]
        static void Main()
        {
            Logger.Configura();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
