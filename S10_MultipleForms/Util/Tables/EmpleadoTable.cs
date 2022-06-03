using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S10_MultipleForms.Util.Entity;
using System.Data.SqlClient;

namespace S10_MultipleForms.Util.Tables
{
    class EmpleadoTable
    {
        public void insertEmpleado(Empleado empleado)
        {
            var url = "INSERT INTO EmpleadoTable(nameEmpleado, edadEmpleado, fnacimientoEmpleado, hijosEmpleado, elaboralEmpleado, sueldoEmpleado) " +
                "values (@nameEmpleado, @edadEmpleado, @fnacimientoEmpleado, @hijosEmpleado, @elaboralEmpleado, @sueldoEmpleado);";

            using (SqlCommand command = new SqlCommand(url, S10_MultipleForms.getInstance().getSQL().getConnection()))
            {
                command.Parameters.AddWithValue("@nameEmpleado", empleado.getNameEmpleado());
                command.Parameters.AddWithValue("@edadEmpleado", empleado.getEdadEmpleado());
                command.Parameters.AddWithValue("@fnacimientoEmpleado", empleado.getFNacimientoEmpleado());
                command.Parameters.AddWithValue("@hijosEmpleado", empleado.getHijosEmpleados());
                command.Parameters.AddWithValue("@elaboralEmpleado", empleado.getElaboralEmpelados());
                command.Parameters.AddWithValue("@sueldoEmpleado", empleado.getSueldoEmpleado());
                command.ExecuteNonQuery();
            };
        }


    }
}
