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

        private void ClientPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Axel axel = new Axel();
            axel.Show();
        }

        private void EmpleadoPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Sauul saul = new Sauul();
            saul.Show();
        }

        private void buttonCalcularSalario_MouseClick(object sender, MouseEventArgs e)
        {
            Camila camila = new Camila();
            camila.Show();
        }

        private void ProductPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Melissa melissa = new Melissa();
            melissa.Show();
        }

        private void buttonCalcularGanancias_MouseClick(object sender, MouseEventArgs e)
        {
            Joyce joyce = new Joyce();
            joyce.Show();
        }

        private void ComprarPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Dicarlo dicarlo = new Dicarlo();
            dicarlo.Show();
        }
    }
}
