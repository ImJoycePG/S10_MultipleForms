using S10_MultipleForms.Util.Entity;
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
    public partial class Axel : Form
    {
        public Axel()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Axel_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellidos.Text) && string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Ingrese los datos a las casillas vacias  correspondientes  ");

                return;
            }
            int num = 0;
            int num1 = 0;

            if (!int.TryParse(txtDni.Text, out num) || !int.TryParse(txtTelefono.Text, out num1))
            {
                txtDni.Text = "";
                txtTelefono.Text = "";

                MessageBox.Show("Ingrese Valores numericos a las casillas correspondientes ");
                return;
            }

            String firstName = txtNombre.Text;
            String lastName = txtApellidos.Text;
            String dni = txtDni.Text;
            String telefono = txtTelefono.Text;
            String direccion = txtDireccion.Text;
            String email = txtCorreo.Text;

            Cliente cliente = new Cliente();
            cliente.setFirstNameClient(firstName);
            cliente.setLastNameClient(lastName);
            cliente.setDNIClient(dni);
            cliente.setPhoneClient(telefono);
            cliente.setDireccionClient(direccion);
            cliente.setEmailClient(email);

            S10_MultipleForms.getInstance().getClientTable().insertClient(cliente);

            string cadena = txtNombre.Text + " " + txtApellidos.Text + " " + " Cliente Registrado";
            MessageBox.Show(cadena);

            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
