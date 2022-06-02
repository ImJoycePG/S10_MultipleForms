using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S10_MultipleForms.Util.Entity;
using System.Data.SqlClient;

namespace S10_MultipleForms.Util.Tables
{
    class ProvTable{

        public void insertProv(Proveedor proveedor){
            var url = "INSERT INTO ProveedorTable(idProv, nameProv, phoneProv, emailProv) values (@idProv, @nameProv, @phoneProv, @emailProv);";

            using (SqlCommand command = new SqlCommand(url, S10_MultipleForms.getInstance().getSQL().getConnection())) {
                command.Parameters.AddWithValue("@idProv", proveedor.getIDProv());
                command.Parameters.AddWithValue("@nameProv", proveedor.getNameProv());
                command.Parameters.AddWithValue("@phoneProv", proveedor.getPhoneProv());
                command.Parameters.AddWithValue("@emailProv", proveedor.getEmailProv());
                command.ExecuteNonQuery();
            };
        }        
    }
}
