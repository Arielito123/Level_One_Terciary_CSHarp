using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un Programa que permita a un usuario ingresar un número desde el teclado y
que luego lo informe, se deberá pedir el ingreso mediante la leyenda “Por favor
ingrese un número” y luego informar con la forma “El número ingresado
es:”*/
            int numero1;
            Console.WriteLine("Porfavor Ingrese un numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero ingresado fue:" + numero1);
            Console.ReadKey();
        }
    }
}
