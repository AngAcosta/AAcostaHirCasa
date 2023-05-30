using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Trinagulo
    {
        public float baseT, altura;
        public float area()
        {
            return (baseT * altura) / 2;
        }
    }

    //public static BL.Trinagulo achatar(Trinagulo t)
    //{
    //    Trinagulo nuevoT = new Trinagulo();
    //    nuevoT.baseT = t.baseT;
    //    nuevoT.altura = t.altura * 0.9f;
    //    return nuevoT;
    //}
}