﻿using System;

namespace Sopra.Labs.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //MostrarTablaMultiplicar();
           //MostrarValores();
           CalcularValores();
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

        /// <summary>
        /// Pregunta al usuario por un valor Inical y Final, así como la magnitud del salto que desea.
        /// Por consola se muestran valores desde el inicial hasta el final en saltos de la magnitud especificada.
        /// </summary>
        static void MostrarValores()
        {
            Console.WriteLine("Escriba el valor inicial");
            int valorInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor final");
            int valorFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Especifique la magnitud del salto");
            int magnitudSalto = int.Parse(Console.ReadLine());

            int valor = valorInicial;
            int signo = 1;
            
            if (valorInicial > valorFinal) { signo = -1; }
            
            while (signo*valor <= signo*valorFinal)
            {
               Console.WriteLine(valor);
               valor = valor + signo*magnitudSalto;
               if (signo*valor > signo*valorFinal) { Console.WriteLine(valorFinal); }
            }
            // desde el valor de inicio al valor final en saltos. el usuario indica tanto los valores de inicio y final como la magnitud del salto
        }

        /// <summary>
        /// Se calcula y muestra por consola el máximo, mínimo, media y suma total de una serie de valores introducidos por el usuario, 
        /// </summary>
        static void CalcularValores()
        {
            Console.WriteLine("¿cuántos valores desea introducir?");
            int numeroValores = int.Parse(Console.ReadLine());
            int[] conjuntoValores = new int[numeroValores];

            for (int i = 0; i < numeroValores; i++)
            {
                Console.WriteLine($"introduzca el valor numero {i+1}");
                conjuntoValores[i] = int.Parse(Console.ReadLine());
            }

            int max = conjuntoValores[0]; 
            int min = conjuntoValores[0];
            int suma = 0;

            foreach (var item in conjuntoValores)
            {

               if (item > max) { max = item; }
               if (item < min) { min = item; }
 
               suma = suma + item;
            }

            var media = suma/numeroValores;

            Console.WriteLine($"El valor máximo es: {max}");
            Console.WriteLine($"El valor mínimo es: {min}");
            Console.WriteLine($"El valor medio es: {media}");
            Console.WriteLine($"La suma total es: {suma}");

            //numero de valores
            // almacenamos en un Array
            // calculo de max, min, media, suma
        }

        /// <summary>
        /// Calcula la letra correspondiente a la parte numérica de un DNI introducido por el usuario 
        /// </summary>
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
