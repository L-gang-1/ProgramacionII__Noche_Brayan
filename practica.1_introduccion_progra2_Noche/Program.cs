using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica._1_introduccion_progra2_Noche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int b = int.Parse(Console.ReadLine());

            int suma = a + b;

            Console.WriteLine("La suma es : " + suma);
            /*
            //Crear tipo de dato
            int numero = 0;
           
            //salida texto
            Console.WriteLine("Hola progra 2");
            Console.WriteLine("Ingresar DAtos: ");
            //ingresar valores
            numero = int.Parse(Console.ReadLine());
            //salida de valores
            Console.WriteLine("El numero ingresado es: " + numero);*/

            
        }
    }
}
