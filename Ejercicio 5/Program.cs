using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un algoritmo que permita realizar el intercambio entre dos variables numéricas
            luego informar por pantalla*/
            int numero1, numero2, aux;
            Console.WriteLine("digite numero 1");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el numero 2");
            numero2 = int.Parse(Console.ReadLine());

            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

            Console.WriteLine("El valor cambiado de numero 1 es: " + numero1 + "\nEl valor cambiado de numero 2 es: " + numero2);
            Console.ReadKey();
        }
    }
}
