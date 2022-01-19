/*
 * Haz un programa que realice la media de los valores que contiene un array de 10 int y lo muestre por consola. No es necesario pedir los números al usuario. 
 * Pista:
 * Podemos ir sumando en cada vuelta del bucle cada valor de cada posición del array.
 */
using System;

namespace _12_Ejercicio_Repaso04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            int suma = 0;

            int[] valores = new int[10];
            for (int i = 0; i < 10; i++)
            { 
                Console.WriteLine("Introduzca un valor:");
                valores[i] = Convert.ToInt32(Console.ReadLine());
                suma = suma + valores[i];
            }
            Console.WriteLine("La media de sus valores introducidos es: " + suma / 10+","+suma%10);
        }
    }
}
