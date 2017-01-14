using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";

            float radianas = 0;

            float resultado = 0;


            Console.WriteLine("Ingrese Numero Radianaes a convertir  "); // Escribe por pantalla un string 
            entrada = Console.ReadLine();
            radianas = Convert.ToSingle(entrada);
            resultado = (3.14f * radianas) / 180;

            Console.Write("Resultado es " + resultado);
            Console.ReadKey();

        }
    }
}