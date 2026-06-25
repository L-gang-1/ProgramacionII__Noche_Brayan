using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int tabla = 1; tabla <= 12; tabla++) {
                Console.WriteLine("ingrese el numero:   " + tabla);

                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine(tabla + " x " + i +" = "+ (tabla * i));
                }

            }


            
        }
    }
}
