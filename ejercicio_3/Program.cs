using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la moneda boliviana : ");
            double bolivianos = Convert.ToDouble(Console.ReadLine());

            double tipoCambio = 6.96;
            double dolares = bolivianos / tipoCambio;
            Console.WriteLine()
        }
    }
}
