using S10_MultipleForms.Util.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_MultipleForms.Util.Tables
{
    class ProductTable
    {

        public void insertProduct(Product product)
        {
            var url = "INSERT INTO ProductTable(firstNameClient, lastNameClient, DNIClient) " +
                "values (@idProduct, @nameProduct, @precioProduct);";

            using (SqlCommand command = new SqlCommand(url, S10_MultipleForms.getInstance().getSQL().getConnection()))
            {
                command.Parameters.AddWithValue("@idProduct", product.getIDProduct());
                command.Parameters.AddWithValue("@nameProduct", product.getNameProduct());
                command.Parameters.AddWithValue("@precioProduct", product.getPrecioProduct());
                command.ExecuteNonQuery();
            };
        }
    }
}
