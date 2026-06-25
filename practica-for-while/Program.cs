using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_for_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ClaveCorrecta = 1234;
            Console.WriteLine("Ingrese su calve");

            int clave = int.Parse(Console.ReadLine());

            while (clave != 1234)
            {
                Console.WriteLine("Clave incorrecta. intente de nuevo");
                clave = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Bienvenido al sistema");
            /*
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("numero", + i);
            }*/ 
        }
    }
}
