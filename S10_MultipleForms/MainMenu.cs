using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S10_MultipleForms
{
    public partial class MainMenu : Form
    {
        private S10_MultipleForms instance = S10_MultipleForms.getInstance();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitImage_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProvPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Alexis alexis = new Alexis();
            alexis.Show();
        }
    }
}
