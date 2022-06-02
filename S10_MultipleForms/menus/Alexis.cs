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
    public partial class Alexis : Form
    {
        private S10_MultipleForms instance = S10_MultipleForms.getInstance();
        public Alexis()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {

            String nombre = textNOMBRE.Text;
            String id = textID.Text;
            String telefono = textTELEFONO.Text;
            String correo = textCORREO.Text;

            Proveedor proveedor = new Proveedor();
            proveedor.setIDProv(id);
            proveedor.setNameProv(nombre);
            proveedor.setPhoneProv(telefono);
            proveedor.setEmailProv(correo);
            instance.GetProvTable().insertProv(proveedor);
            MessageBox.Show("Proveedor Agregado");
            cleanText();


        }

        private void cleanText()
        {
            textCORREO.Text = "";
            textNOMBRE.Text = "";
            textTELEFONO.Text = "";
            textID.Text = "";
        }
    }
}
