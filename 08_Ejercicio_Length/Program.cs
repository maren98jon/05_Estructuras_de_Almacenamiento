/*
 * Crear un array de 10 ints,  asigna un valor a cada uno de las 10 posiciones y finalmente muestra los 10 valores en pantalla.
 */
using System;

namespace _08_Ejercicio_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            int[] valores = { 6432,456,243,876,345,987,34,10,976,111};
            for (int i = 0; i <= valores.Length - 1; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
