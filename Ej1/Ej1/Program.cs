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
            
            double perimetro = 0, lado = 0, cantidad = 0;

           
            Console.WriteLine("Encontrar el Perimetro  de un Poligono.");
           

            Console.Write("Ingrese cantidad de lados del Poligono: ");
            cantidad = Int32.Parse(Console.ReadLine());

           
            Console.Write("Ingrese el lados del Poligono: ");
           lado = Int32.Parse(Console.ReadLine());





            
            perimetro = cantidad * lado;

           
            Console.WriteLine("El Area del Poligono: " + perimetro);



            Console.ReadKey();
        }

    }

}
