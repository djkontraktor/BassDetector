using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BassDetector
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread formThread = new Thread(new ThreadStart(StartForm));
            formThread.SetApartmentState(ApartmentState.STA);
            formThread.Start();

            //Application.Run(new MainForm());
        }

        static void StartForm()
        {
            Application.Run(new MainForm());
        }
    }
}
