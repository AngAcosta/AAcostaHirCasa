using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Grupo
    {
        public int IdDepartamento { get; set; }

        public string NombreGrupo { get; set; }

        public List<object> Oficinas { get; set; }
    }
}