using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
  

                int pares = 0, impares = 0;

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("Ingrese un número: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num % 2 == 0)
                        pares++;
                    else
                        impares++;
                }

                Console.WriteLine("Pares: " + pares);
                Console.WriteLine("Impares: " + impares);
            }
        }
    }
    

