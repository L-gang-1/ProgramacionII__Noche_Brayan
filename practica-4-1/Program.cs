using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("ingrese una Vector");
            int n = int.Parse(Console.ReadLine());
            int[] vec = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Valor de vector " + (i + 1));
                vec[i ] = int.Parse(Console.ReadLine());
                suma = suma + vec[i];

            }
            Console.WriteLine("LA suma total es: " + suma);
        }
    }
}
