using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sabiendo que un vehículo recorre 100km con 12,5 litros de combustible, realizar un
Programa  que le permita al usuario ingresar litros de combustible para informar cuántos
kilómetros podrá recorrer*/

            float ingl;
            float dr = 0;



            Console.WriteLine("Ingrese los litros deseados para su vehiculo");
            ingl = float.Parse(Console.ReadLine());

            dr = (float)((ingl * 100) / 12.5);
            Console.WriteLine("La Distancia Reccorida con el vehiculo es de" + dr + "km");
            Console.ReadKey();
        }
    }
}
