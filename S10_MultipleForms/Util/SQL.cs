using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace S10_MultipleForms{
    class SQL{
        private SqlConnection connection = null;
        private SqlCommand command = null;

        public SqlConnection getConnection()
        {
            try
            {
                if (connection == null && connection.State == ConnectionState.Closed)
                {
                    return connectSQL();
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection;
        }

        public SqlConnection connectSQL(){
            try
            {
                string source = "IMJOYCEPG";
                string catalog = "S10_MultipleForms";
                string userID = "Joyce";
                string password = "12345";

                string url = "Data Source=" + source + ";Initial Catalog =" + catalog + ";User id=" + userID + ";Password=" + password;

                connection = new SqlConnection(url);
                connection.Open();
                MessageBox.Show("-> Se conectó correctamente a la base SQL.");

                var tableProveedor = "IF NOT EXISTS (SELECT * FROM sysobjects " +
                    "where name='ProveedorTable' and xtype='U')" +
                    "CREATE TABLE ProveedorTable(" +
                    "idProv varchar(16) not null," +
                    "nameProv varchar(36) not null," +
                    "phoneProv varchar(16)," +
                    "emailProv varchar(36)," +
                    "CONSTRAINT PK_IDPROV PRIMARY KEY (idProv));";

                command = new SqlCommand(tableProveedor, connection);
                command.ExecuteNonQuery();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return connection;
        }
    }
}
