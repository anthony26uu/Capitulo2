using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = "";


            int i = 0;
            float conversion = 0f;
            float cantidad = 0f;
            float resultado = 0f;

            Console.WriteLine("\t \t Conversor de Monedas \n \n Ingrese Opcion deseada \n 1- Conversion de dolar \n Conversion de Euros  "); // Escribe por pantalla un string

            entrada = Console.ReadLine();
            i = System.Int32.Parse(entrada);
            //   i = Convert.ToSingle(entrada);
            switch (i)
            {
                case 1:
                    Console.WriteLine("Usted seleciono Convercion de dolar ");
                    Console.Write("Ingrese taza de camnbio del dia: ");
                    entrada = Console.ReadLine();
                    conversion = Convert.ToSingle(entrada);
                    Console.Write("\n Ingrese cantidad de dolares a convertir ");
                    entrada = Console.ReadLine();
                    cantidad = Convert.ToSingle(entrada);
                    resultado = cantidad * conversion;
                    Console.Write("\n Resultado de conversion es  {0 }", resultado);


                    break;
                case 2:

                    Console.WriteLine("Usted seleciono Convercion de Euros ");
                    Console.Write("Ingrese taza de camnbio del dia: ");
                    entrada = Console.ReadLine();
                    conversion = Convert.ToSingle(entrada);
                    Console.Write("\n Ingrese cantidad de dolares a convertir ");
                    entrada = Console.ReadLine();
                    cantidad = Convert.ToSingle(entrada);
                    resultado = cantidad * conversion;
                    Console.Write("\n Resultado de conversion es  {0 }", resultado);

                    break;
                default:

                    break;
            }


            //    Console.WriteLine("Ingrese Numero Grados centígrados  a convertir  "); // Escribe por pantalla un string 
            //  entrada = Console.ReadLine();




            //       Console.Write("Resultado es " + resultado);
            Console.ReadKey();



        }
    }
}
