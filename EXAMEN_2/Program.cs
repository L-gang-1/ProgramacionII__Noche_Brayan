using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("examen 2");
                Console.WriteLine("1. numero entero pares");
                Console.WriteLine("2. Comodin");


                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
               

                            Console.WriteLine("imgresa un numero par: ");
                            int n = int.Parse(Console.ReadLine());
                            if (n <= 0)
                            {

                                Console.WriteLine("el numero no es valido");
                                return;
                            }
                            int suma = 0;

                            for (int i = 0; i < n; i++) {
                            int
                                numero = int.Parse(Console.ReadLine());




                        }
                        break;
                    case 2:
                        */
                        Console.WriteLine("ingrese un texto; ");
                        string texto = Console.ReadLine();

                        string invertido = "";

                        for (int i = texto.Length - 1; i >= 0; i--) {
                            {
                                invertido += texto[i];
                            }
                            Console.WriteLine("el texto invertido es: " + invertido);

                            break;




                }   

        }
    }
}