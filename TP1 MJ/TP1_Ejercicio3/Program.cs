using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 Realizar un programa de consola que permita ingresar un numero y calcule la suma de todos los numeros enteros anteriores
            Console.WriteLine("Ingresar un numero");
            int numeroIngresado = Console.Read();
            int sumatoriaTotal = 0;

            for (int i = 0; i < numeroIngresado; i++)
            {
                sumatoriaTotal += i;
                Console.Read();
            }
            Console.WriteLine("La sumatoria de los numeros ingresados es: " + sumatoriaTotal);
        }
    }
}
