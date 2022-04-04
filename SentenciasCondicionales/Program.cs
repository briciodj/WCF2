using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciasCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            if (num > 5)
            {
                Console.WriteLine("num es mayor que 5");
            }


            //Condicional compuesta
            string usuario = "usuario1";
            string contraseña = "12345";
            if (usuario == "usuario1" && contraseña == "12345") 
            {
                Console.WriteLine("Acceso permitido");
            }



            // if else 
            int edad = 18;
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }



            //if - else if

            int a = 6;
            int b = 8;
            if (a > b)
            {
                Console.WriteLine( "{0} > {1}", a, b );
            }
            else if (a < b)
            {
                Console.WriteLine("{0} < {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} == {1}", a, b);
            }




            // switch
            string codigo = "B3";
            switch (codigo)
            {
                case "B1":
                    Console.WriteLine("Producto 1");
                    break;
                case "B2":
                    Console.WriteLine("Producto 2");
                    break;
                case "B3":
                    Console.WriteLine("Producto 3");
                    break;
                default:
                    Console.WriteLine("Producto  no encontrado");
                    break;

            }

        }
    }
}
