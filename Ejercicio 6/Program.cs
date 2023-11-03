using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*. Armar un Programa que permita al usuario ingresar su edad para 
             luego informar el año en que nació.*/

            int edad, Fecha, nacimiento;

            Console.WriteLine("digite su edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("digite La Fecha Actual");
            Fecha = int.Parse(Console.ReadLine());

            nacimiento = edad - Fecha;

            Console.WriteLine("Usted nacio en : " + nacimiento);
            Console.ReadKey();

        }
    }
}

