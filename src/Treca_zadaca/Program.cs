using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treca_zadaca
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DB.SetConfiguration("PI2425_ltomecak23_DB", "PI2425_ltomecak23_User", "/ch|_H}i");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pocetak());
        }
    }
}
