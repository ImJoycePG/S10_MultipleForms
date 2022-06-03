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
    public partial class Joyce : Form
    {
        public Joyce()
        {
            InitializeComponent();

        }

        private void imageRegister_Click(object sender, EventArgs e)
        {
            int tempNum1 = 0;
            int tempNum2 = 0;
            int resultGanancia = 0;
            string resultCadena;

            if (string.IsNullOrEmpty(rpta_idProduct.Text) || string.IsNullOrEmpty(rpta_nameProduct.Text) ||
                string.IsNullOrEmpty(rpta_compra.Text) || string.IsNullOrEmpty(rpta_venta.Text))
            {
                MessageBox.Show("Debes completar las casillas");
                return;
            }

            if (!int.TryParse(rpta_venta.Text, out tempNum1) || !int.TryParse(rpta_compra.Text, out tempNum2))
            {
                rpta_venta.Text = "";
                rpta_compra.Text = "";

                MessageBox.Show("Debes ingresar correctamente los numeros en ciertas casillas.");
                return;
            }

            int venta = int.Parse(rpta_venta.Text);
            int compra = int.Parse(rpta_compra.Text);

            resultGanancia = (venta - compra);



            resultCadena = "Resumen del proceso:\nIDProducto: " + rpta_idProduct.Text + "\nNombre del producto: " + rpta_nameProduct.Text +
                            "\nCosto de venta: " + rpta_venta.Text + "\nCosto de compra: " + rpta_compra.Text +
                            "\nGanancia: " + resultGanancia;

            MessageBox.Show(resultCadena);


        }

        private void imagenCancelRegister_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
