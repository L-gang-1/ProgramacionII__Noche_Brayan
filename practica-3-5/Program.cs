using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            long resultado = CalcularFactorialIterativo(numero);
            Console.WriteLine($"El factorial de {numero} es: {resultado}");
        }

  
            if (n < 0) return -1; 

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;

            

            }
        }
    }
}
