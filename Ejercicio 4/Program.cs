using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se solicita el ingreso de un número, se informa dicho número elevado al cubo.

            int numero, cubo = 0;

            Console.WriteLine("Digite un numero");
            numero = int.Parse(Console.ReadLine());

            cubo = numero * numero * numero;

            Console.WriteLine("Su Numero elevado al cubo da:" + cubo);
            Console.ReadKey();

        }
    }
}
