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
    public partial class Camila : Form
    {
        public Camila()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSalarioTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreTrabajador = txtNombreTrabajador.Text;
            if (nombreTrabajador.Equals(""))
            {
                MessageBox.Show("Ingrese un nombre");
            }

            double salarioFijo = 0;
            if (cboSalarioFijo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Salario");
            }
            if (cboSalarioFijo.SelectedIndex == 0)
            {
                salarioFijo = 1000;
            }
            if (cboSalarioFijo.SelectedIndex == 1)
            {
                salarioFijo = 1250;
            }
            if (cboSalarioFijo.SelectedIndex == 2)
            {
                salarioFijo = 1300;
            }
            if (cboSalarioFijo.SelectedIndex == 3)
            {
                salarioFijo = 1500;
            }
            if (cboSalarioFijo.SelectedIndex == 4)
            {
                salarioFijo = 1650;
            }

            double comisionPorVenta = 0;
            if (cboComisionPorVenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Salario");
            }
            if (cboComisionPorVenta.SelectedIndex == 0)
            {
                comisionPorVenta = 5;
            }
            if (cboComisionPorVenta.SelectedIndex == 1)
            {
                comisionPorVenta = 10;
            }
            if (cboComisionPorVenta.SelectedIndex == 2)
            {
                comisionPorVenta = 15;
            }

            int cantidadVentasRealizadas = 0;

            if (!int.TryParse(txtCantidadDeVentasRealizadas.Text, out cantidadVentasRealizadas))
            {
                MessageBox.Show("Ingrese un valor numerico");
                return; //Salimos
            }
            else
            {
                cantidadVentasRealizadas=int.Parse(txtCantidadDeVentasRealizadas.Text);
            }

            double salarioTotal = 0;
            salarioTotal = salarioFijo + comisionPorVenta * cantidadVentasRealizadas;

            MessageBox.Show("Hola " + nombreTrabajador + "! Tu salario total del mes es: S/." + salarioTotal);
            
        }

        private void cboSalarioFijo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtNombreTrabajador.ResetText();
            cboSalarioFijo.ResetText();
            cboComisionPorVenta.ResetText();
            txtCantidadDeVentasRealizadas.ResetText();
        }
    }
}
