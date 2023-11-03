using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un algoritmo que le solicite al usuario ingresar dos número y luego informe
   la sumatoria, el producto y la diferencia entre ambos.*/

            int numero1, numero2, suma = 0, diferencia = 0, producto = 0;

            Console.WriteLine("Ingrese el numero 1");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            numero2 = int.Parse(Console.ReadLine());

            suma = numero1 + numero2;
            diferencia = numero1 - numero2;
            producto = numero1 * numero2;

            Console.WriteLine("La suma de sus dos numero es de:" + suma);
            Console.WriteLine("La diferencia de sus dos numeros es de:" + diferencia);
            Console.WriteLine("El producto de sus dos numeros es de:" + producto);
            Console.ReadKey();
        }
    }
}
