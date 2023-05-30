using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Persona
    {
        public static ML.Result CambiaNombre(ML.Persona persona)
        {
            ML.Result result = new ML.Result();

            Console.WriteLine("Hola_" + persona.Nombre);

            int Calcular = 0;

            Calcular = int.Parse(persona.Edad) * int.Parse(persona.Peso);

            Console.WriteLine();
            Console.WriteLine("La edad por el peso es:" + Calcular);
            return result;
        }
    }
}