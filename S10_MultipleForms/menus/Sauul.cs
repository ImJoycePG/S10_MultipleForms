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
    public partial class Sauul : Form
    {
        public Sauul()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            int edad = Convert.ToInt16(txtEdad.Text);
            String fnacimiento = txtFNacimiento.Text;
            String direccion = txtDireccion.Text;
            int hijos = Convert.ToInt16(txtHijos.Text);
            String elaboral = txtELaboral.Text;
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            if (nombre == "" || fnacimiento == "" || direccion == "" || elaboral == "")
            {
                MessageBox.Show("Ingrese todos los datos requeridos");
                return;
            }
            if (!int.TryParse(txtEdad.Text, out edad) || !int.TryParse(txtHijos.Text, out hijos) || !double.TryParse(txtSueldo.Text, out sueldo))
            {
                txtEdad.Text = "";
                txtHijos.Text = "";
                txtSueldo.Text = "";
                MessageBox.Show("Ingrese sólo valores numericos en los espacios correspondientes ");
                return;
            }

            Empleado empleado = new Empleado();
            empleado.setNameEmpleado(nombre);
            empleado.setEdadEmpleado(edad);
            empleado.setFNacimientoEmpleado(fnacimiento);
            empleado.setDireccionEmpleado(direccion);
            empleado.setHijosEmpleados(hijos);
            empleado.setElaboralEmpleados(elaboral);
            empleado.setSueldoEmpleado(sueldo);

            S10_MultipleForms.getInstance().getEmpleadoTable().insertEmpleado(empleado);
            MessageBox.Show("Empleado Registrado correctamente");
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            txtEdad.ResetText();
            txtFNacimiento.ResetText();
            txtDireccion.ResetText();
            txtHijos.ResetText();
            txtELaboral.ResetText();
            txtSueldo.ResetText();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
