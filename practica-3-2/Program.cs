using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la compra");

            int ventas  = int.Parse(Console.ReadLine());

            while (ventas != 0)
            {
                Console.WriteLine("Clave incorrecta. intente de nuevo");
                ventas = int.Parse(Console.ReadLine());
                ventas = ventas - 1;

            }
            Console.WriteLine("Bienvenido al sistema", - ventas);
        }
    }
}
