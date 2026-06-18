using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA1_2DO_BI
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ingrese el primer numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int b = int.Parse(Console.ReadLine());

            int suma = a + b;

            Console.WriteLine("La suma es : " + suma);
        }

    }
}
