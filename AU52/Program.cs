using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AU52
{
     class Program
    {
        static void Main(string[] args)
        {
            // Arreglo de números enteros
            int[] enteros = { 1, 2, 3, 4, 5 };

            // Arreglo de números reales
            double[] reales = { 2.3, 4.5, 6.7, 8.9 };

            // Arreglo de cadenas de caracteres
            string[] cadenas = { "Hola", "Mundo", "!", "Estoy", "aprendiendo", "C#" };

            // Arreglo de booleanos
            bool[] booleanos = { true, false, true, true, false };

            // Arreglo bidimensional de números enteros
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // Accediendo a elementos de los arreglos
            Console.WriteLine(enteros[3]); // Imprime el cuarto elemento del arreglo de enteros
            Console.WriteLine(reales[reales.Length - 1]); // Imprime el último elemento del arreglo de reales
            Console.WriteLine(string.Join(", ", cadenas, 2, 3)); // Imprime los elementos del arreglo de cadenas desde el tercero hasta el quinto
            Console.WriteLine(string.Join(", ", booleanos, 1, booleanos.Length - 1)); // Imprime los elementos del arreglo de booleanos desde el segundo hasta el último
            Console.WriteLine(matriz[1, 2]); // Imprime el elemento en la segunda fila y tercera columna de la matriz

            // Modificando elementos de los arreglos
            enteros[2] = 10; // Modifica el tercer elemento del arreglo de enteros
            reales[reales.Length - 1] = 9.8; // Modifica el último elemento del arreglo de reales
            Array.Copy(new string[] { "Estoy", "practicando" }, 0, cadenas, 3, 2); // Modifica los elementos del arreglo de cadenas desde el cuarto hasta el quinto
            booleanos[0] = false; // Modifica el primer elemento del arreglo de booleanos
            matriz[0, 2] = 0; // Modifica el elemento en la primera fila y tercera columna de la matriz

            // Imprimiendo los arreglos modificados
            Console.WriteLine(string.Join(", ", enteros));
            Console.WriteLine(string.Join(", ", reales));
            Console.WriteLine(string.Join(", ", cadenas));
            Console.WriteLine(string.Join(", ", booleanos));
            Console.WriteLine(string.Join(", ", matriz));
        }
    }
}
    

