/*
 * Crear un array de 3 ints. Asignar un valor a cada uno de las 3 posiciones. Mostrar los 3 valores en pantalla.
 */
using System;

namespace _04_Ejercicio_Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            int[] valores = new int[3];
            valores[0] = 2;
            valores[1] = 456;
            valores[2] = 31;
            for (int i = 0; i<=2; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
