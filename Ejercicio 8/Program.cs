using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sabiendo que la superficie de un círculo se determina con la expresión S=π*r2
desarrollar un programa que permita calcular e informar dicha superficie, se tratará de
que el mismo sea lo más interactivo posible, es decir, se deberán mostrar leyendas
indicando al usuario lo que debe hacer. Además se deberá informar el resultado con la
forma “La superficie del círculo es:”*/

            float radio, superficie = 0;
            Double pi = 3.14;

            Console.WriteLine("Introduzca el radio de su circulo");
            radio = float.Parse(Console.ReadLine());

            superficie = (float)(pi * (radio * radio));
            Console.WriteLine("La Superficie de su circulo es:" + superficie);
            Console.ReadKey();
        }
    }
}
