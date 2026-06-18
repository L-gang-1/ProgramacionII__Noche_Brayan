using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base del triángulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo: ");
            double altura = double.Parse(Console.ReadLine());

            double area = (baseTriangulo * altura) / 2;

            Console.WriteLine("El área del triángulo es: " + area);
        }
    }
}
