/*
 * Crear un array de 10 ints. Usar un for para asignar los valores de 20 a 11 a las 10 posiciones 
 * (en orden descendente). Usar un for para mostrar los 10 valores en pantalla.
 */
using System;

namespace _10_Ejercicio_Repaso02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            int[] valores = new int[10];
            for (int i = 0; i < 10; i++)
            {
                valores[i] = 20 - i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(valores[i]);
            }

        }
    }
}
