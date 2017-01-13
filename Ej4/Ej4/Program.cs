using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string entrada = "";

            float c = 0;

            float resultado = 0;


            Console.WriteLine("Ingrese Numero Grados centígrados  a convertir  "); // Escribe por pantalla un string 
            entrada = Console.ReadLine();
            c = Convert.ToSingle(entrada);

            resultado = (c * 9 / 5) + (32);

            Console.Write("Resultado es " + resultado);
            Console.ReadKey();



        }
    }
}



