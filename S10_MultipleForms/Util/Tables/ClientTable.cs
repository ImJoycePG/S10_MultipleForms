using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S10_MultipleForms.Util.Entity;
using System.Data.SqlClient;

namespace S10_MultipleForms.Util.Tables
{
    class ClientTable
    {

        public void insertClient(Cliente client)
        {
            var url = "INSERT INTO ClientTable(firstNameClient, lastNameClient, DNIClient, phoneCliente, direccionClient, emailClient) " +
                "values (@firstNameClient, @lastNameClient, @DNIClient, @phoneCliente, @direccionClient, @emailClient);";

            using (SqlCommand command = new SqlCommand(url, S10_MultipleForms.getInstance().getSQL().getConnection()))
            {
                command.Parameters.AddWithValue("@firstNameClient", client.getFirstNameClient());
                command.Parameters.AddWithValue("@lastNameClient", client.getLastNameClient());
                command.Parameters.AddWithValue("@DNIClient", client.getDNIClient());
                command.Parameters.AddWithValue("@phoneCliente", client.getPhoneClient());
                command.Parameters.AddWithValue("@direccionClient", client.getDireccionClient());
                command.Parameters.AddWithValue("@emailClient", client.getEmailClient());
                command.ExecuteNonQuery();
            };
        }
    }
}
