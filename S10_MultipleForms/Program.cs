using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S10_MultipleForms
{
    internal static class Program{
        [STAThread]
        static void Main(){
            S10_MultipleForms.getInstance().onStart();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
