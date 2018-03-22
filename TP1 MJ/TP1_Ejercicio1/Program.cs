using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Realizar un programa de consola que permita ingresar el nombre y apellido por separado, con estos datos debe imprimir un mensaje con el nombre completo.
            Console.WriteLine("Ingrese un nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese un apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine(nombre + " " + apellido);
            Console.Read();
        }
    }
}
