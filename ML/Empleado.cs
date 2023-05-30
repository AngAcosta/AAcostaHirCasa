using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        
        public string Nombre { get; set; }

        public string  Puesto { get; set; }

        public string Salario { get; set; }

        public string Supervisor { get; set; }

        public string Grupo { get; set; }

        public List<object> Empleados { get; set; }
    }
}