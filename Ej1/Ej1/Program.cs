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
            //Variables Auxiliares
            double perimetro = 0, lado = 0, cantidad = 0;

            //Explicacion del ejercicio
            Console.WriteLine("Encontrar el Perimetro  de un Poligono.");
           

            Console.Write("Ingrese cantidad de lados del Poligono: ");
            cantidad = Int32.Parse(Console.ReadLine());

            //Pediendo datos
            Console.Write("Ingrese el lados del Poligono: ");
            //Convierte de texto a tipo entero
            lado = Int32.Parse(Console.ReadLine());





            //Realiza la operacion
            perimetro = cantidad * lado;

            //Imprimiendo el resultado
            Console.WriteLine("El Area del Cuadrado: " + perimetro);



            Console.ReadKey();
        }

    }

}
