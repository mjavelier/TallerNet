using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 Realizar un programa de consola que permita ingresar el nombre y la edad, con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.
            Console.WriteLine("Ingrese un nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese una edad");
            int edad = Console.Read();

            bool mayoriadeedad = int.TryParse(Console.ReadLine(), out edad);
            if (mayoriadeedad)
            {
                Console.WriteLine(edad < 18 ? "Es menor de edad" : "Es mayor de edad");
            }
            Console.Read();
        }
    }
}
