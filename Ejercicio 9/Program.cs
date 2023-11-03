using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Modificar el ejercicio anterior de manera que el algoritmo permita determinar la superficie
de un triángulo rectángulo*/

            float cateto1, cateto2, superficie = 0;


            Console.WriteLine("ingrese el valor del primer cateto");
            cateto1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo cateto");
            cateto2 = float.Parse(Console.ReadLine());

            superficie = (cateto1 * cateto2) / 2;

            Console.WriteLine("la superficie de su triangulo es de" + superficie);
            Console.ReadKey();
        }
    }
}
