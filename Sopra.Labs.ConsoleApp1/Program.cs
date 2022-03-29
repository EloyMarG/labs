using System;

namespace Sopra.Labs.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarTablaMultiplicar();
           // CalcularLetraDNI();
        }


        /// <summary>
        /// Muestra la tabla de multiplicar del número introducido por el usuario.
        /// </summary>
        static void MostrarTablaMultiplicar()
        {
            Console.WriteLine("Introduzca un número para calcular Tabla de Multiplicar");
            string num = Console.ReadLine();

            int n = int.Parse(num);


            //usando for
            static void TablaMultiplicarFor(int numero)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(numero * i);
                }
            }



            //usando while
            static void TablaMultiplicarWhile(int numero)
            {
                int i = 0;

                while(i <= 10)
                {
                    Console.WriteLine(numero * i);
                    i++;
                }
            }



            Console.WriteLine("Usando for:");
            TablaMultiplicarFor(n);

            Console.WriteLine("Usando while:");
            TablaMultiplicarWhile(n);
/*
            Console.Clear();
            Console.WriteLine();
            Console.Write("");
            string entrada  = Console.ReadLine();
            Console.ReadKey();


            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Gray;
*/
        }

        static void MostrarValores()
        {
            // desde el valor de inicio al valor final en saltos. el usuario indica tanto los valores de inicio y final como la magnitud del salto
        }



        static void CalcularValores()
        {
            
            //numero de valores
            // almacenamos en un Array
            // calculo de max, min, media, suma
        }


        static void CalcularLetraDNI()
        {
            Console.WriteLine("Introduzca los 8 dígitos de su DNI");
            string entrada = Console.ReadLine();
            int DNI = int.Parse(entrada);
            
            if (DNI <10000000 || DNI >99999999)
            {
                Console.WriteLine("Introduzca un DNI válido");
                CalcularLetraDNI();
                return;
            }

            var resto = DNI % 23;
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            var letra = letras.GetValue(resto);

            Console.WriteLine("La letra de su DNI es: " + letra.ToString());

            // extraer el resto de dividir por 23: numeroDNI % 23
            // posición de Array  de las letras que viene dado
        }

    }
}
