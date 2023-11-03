using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Luego de la lectura del apunte con código AyEDD03, desarrollar un algoritmo que
permita ingresar la edad de una persona para luego informar si la misma es mayor o no.
Se considera mayor de edad a la persona que tiene 18 años o más*/
            int edad;

            Console.WriteLine("Digite su edad");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");

            }
            Console.ReadKey();

        }
    }
}
