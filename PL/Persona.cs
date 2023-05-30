using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Persona
    {
        public static void CambiarNombre()
        {
            ML.Persona persona = new ML.Persona();

            Console.WriteLine("Ingresa el Nombre: ");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Ingresa la Edad: ");
            persona.Edad = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Ingresa el Peso: ");
            persona.Peso = Console.ReadLine();
            Console.WriteLine();

            ML.Result result = BL.Persona.CambiaNombre(persona);
        }
    }
}
