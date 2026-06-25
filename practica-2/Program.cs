using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ClaveCorrecta = 12930815;
            Console.WriteLine("Ingrese su calve");

            int clave = int.Parse(Console.ReadLine());

            while (clave != 12930815)
            {
                Console.WriteLine("Clave incorrecta. intente de nuevo");
                clave = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Bienvenido al sistema Correcto ");
        }
    }
}
