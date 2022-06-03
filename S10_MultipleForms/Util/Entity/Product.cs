using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_MultipleForms.Util.Entity
{
    class Product
    {

        private String nameProduct;
        private String idProduct;
        private double precioProduct;


        public void setNameProduct(String nameProduct) { this.nameProduct = nameProduct; }
        public String getNameProduct() { return nameProduct; }

        public void setIDProduct(String idProduct) { this.idProduct = idProduct; }
        public String getIDProduct() { return idProduct; }

        public void setPrecioProduct(double precioProduct) { this.precioProduct = precioProduct; }
        public double getPrecioProduct() { return precioProduct; }
    }
}
