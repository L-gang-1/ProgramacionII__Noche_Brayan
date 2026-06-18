using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2_2
{
    internal class Program
    {
        static void Main(string[] args)

            {
                Console.Write("Ingrese el primer número: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                int n2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el tercer número: ");
                int n3 = int.Parse(Console.ReadLine());

                int mayor;

                if (n1 > n2 && n1 > n3)
                    mayor = n1;
                else if (n2 > n1 && n2 > n3)
                    mayor = n2;
                else
                    mayor = n3;

                Console.WriteLine("El número mayor es: " + mayor);
            }
        }
    }
    

