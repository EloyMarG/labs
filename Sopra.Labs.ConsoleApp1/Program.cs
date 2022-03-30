using System;

namespace Sopra.Labs.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            //MostrarTablaMultiplicar();
            // MostrarValores();
            //CalcularValores();
            CalcularLetraDNI();
           
        }
        /// <summary>
        /// Se demanda un valor al usuario y no se acepta la entrada hasta que no corresponde con un entero.
        /// </summary>
        /// <param name="textoNormal"></param>
        /// <param name="textoValorNoValido"></param>
        /// <returns></returns>
        static int ForzarEntradaInt(string textoNormal = "", string textoValorNoValido = "Debe introducirse un número ENTERO" )
        {
            int numeroEntero;
            bool valido = false;

            do
            {
              Console.WriteLine(textoNormal);
              valido = int.TryParse(Console.ReadLine(), out numeroEntero);
              if (!valido)
              {
                  Console.WriteLine(textoValorNoValido);
              }  
            
            } while (!valido);

            return numeroEntero;
        }

        /// <summary>
        /// Muestra la tabla de multiplicar del número introducido por el usuario.
        /// </summary>
        static void MostrarTablaMultiplicar()
        {
            int num = ForzarEntradaInt("Introduzca número para calcular Tabla de Multiplicar");


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
            TablaMultiplicarFor(num);

            Console.WriteLine("Usando while:");
            TablaMultiplicarWhile(num);
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

            int valorInicial = ForzarEntradaInt("Escriba el valor inicial");

            int valorFinal = ForzarEntradaInt("Escriba el valor final");

            int magnitudSalto = ForzarEntradaInt("Escriba la magnitud del salto");



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
            int numeroValores = ForzarEntradaInt("¿cuántos valores desea introducir?");
            int[] conjuntoValores = new int[numeroValores];

            for (int i = 0; i < numeroValores; i++)
            {
                conjuntoValores[i] = ForzarEntradaInt($"Introduzca el elemento número {i+1}");
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
            int NIF = ForzarEntradaInt("Introduzca los 8 dígitos de su DNI");
            
            if (NIF <10000000 || NIF >99999999)
            {
                Console.WriteLine("Introduzca un DNI válido");
                CalcularLetraDNI();
                return;
            }

            var resto = NIF % 23;
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            var letra = letras.GetValue(resto);

            Console.WriteLine("La letra de su DNI es: " + letra.ToString());

            // extraer el resto de dividir por 23: numeroDNI % 23
            // posición de Array  de las letras que viene dado
        }

    }
}
