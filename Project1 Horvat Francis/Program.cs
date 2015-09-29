using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_Horvat_Francis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FileReader myFileReader = new FileReader();

            myFileReader.readFile();

            Application.Run(new Form1(myFileReader.getList()));
        }
    }
}
