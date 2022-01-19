/*
 * Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. Mostrar los 10 valores en pantalla.
 */
using System;

namespace _06_Ejercicio_RecorrerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            int[] valores = { 45, 65, 76, 43, 12, 3, 5, 7, 8, 4567 };
            for (int i = 0; i <= valores.Length - 1; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
