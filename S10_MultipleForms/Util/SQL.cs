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

                var tableClient = "IF NOT EXISTS (SELECT * FROM sysobjects " +
                    "where name='ClientTable' and xtype='U')" +
                    "CREATE TABLE ClientTable(" +
                    "firstNameClient varchar(16) not null," +
                    "lastNameClient varchar(16) not null," +
                    "DNIClient varchar(12)," +
                    "phoneCliente varchar(12)," +
                    "direccionClient varchar(64)," +
                    "CONSTRAINT PK_FIRSTNAME PRIMARY KEY (firstNameClient));";


                var tableEmpleado = "IF NOT EXISTS (SELECT * FROM sysobjects " +
                    "where name='EmpleadoTable' and xtype='U')" +
                    "CREATE TABLE EmpleadoTable(" +
                    "nameEmpleado varchar(16) not null," +
                    "edadEmpleado int," +
                    "fnacimientoEmpleado varchar(16)," +
                    "direccionEmpleado varchar(12)," +
                    "hijosEmpleado int," +
                    "elaboralEmpleado varchar(64)," +
                    "sueldoEmpleado decimal," +
                    "CONSTRAINT PK_NAMEEMPLEADO PRIMARY KEY (nameEmpleado));";

                var tableProduct = "IF NOT EXISTS (SELECT * FROM sysobjects " +
                    "where name='ProductTable' and xtype='U')" +
                    "CREATE TABLE ProductTable(" +
                    "idProduct varchar(16) not null," +
                    "nameProduct varchar(32)," +
                    "precioProduct decimal," +
                    "CONSTRAINT PK_IDPRODUCT PRIMARY KEY (idProduct));";

                command = new SqlCommand(tableProveedor, connection);
                command = new SqlCommand(tableClient, connection);
                command = new SqlCommand(tableEmpleado, connection);
                command = new SqlCommand(tableProduct, connection);
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
