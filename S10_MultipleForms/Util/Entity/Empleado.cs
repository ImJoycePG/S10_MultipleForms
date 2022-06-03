using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_MultipleForms.Util.Entity
{
    class Empleado
    {
        private String nameEmpleado;
        private int edadEmpleado;
        private String fnacimientoEmpleado;
        private String direccionEmpleado;
        private int hijosEmpleados;
        private String elaboralEmpleados;
        private double sueldoEmpleado;


        public void setNameEmpleado(String nameEmpleado) { this.nameEmpleado = nameEmpleado; }
        public String getNameEmpleado() { return nameEmpleado; }

        public void setEdadEmpleado(int edadEmpleado) { this.edadEmpleado = edadEmpleado; }
        public int getEdadEmpleado() { return edadEmpleado; }

        public void setFNacimientoEmpleado(String fnacimientoEmpleado) { this.fnacimientoEmpleado = fnacimientoEmpleado; }
        public String getFNacimientoEmpleado() { return fnacimientoEmpleado; }

        public void setDireccionEmpleado(String direccionEmpleado) { this.direccionEmpleado = direccionEmpleado; }
        public String getDireccionEmpleado() { return direccionEmpleado; }

        public void setHijosEmpleados(int hijosEmpleados) { this.hijosEmpleados = hijosEmpleados; }
        public int getHijosEmpleados() { return hijosEmpleados; }

        public void setElaboralEmpleados(String elaboralEmpleados) { this.elaboralEmpleados = elaboralEmpleados; }
        public String getElaboralEmpelados() { return elaboralEmpleados; }

        public void setSueldoEmpleado(double sueldoEmpleado) { this.sueldoEmpleado = sueldoEmpleado; }
        public double getSueldoEmpleado() { return sueldoEmpleado; }

    }
}
