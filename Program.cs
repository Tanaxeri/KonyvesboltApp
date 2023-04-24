using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesboltApp
{
    internal static class Program
    {

        static public SqlData sqldat = null;
        static public StartForm startform = null;
        static public KonyvekForm konyvekform = null;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            sqldat = new SqlData("localhost", "root", "", "konyvesbolt_kesz");
            startform = new StartForm();
            konyvekform = new KonyvekForm();

            startform.Show();

            Application.Run();
        }
    }
}
