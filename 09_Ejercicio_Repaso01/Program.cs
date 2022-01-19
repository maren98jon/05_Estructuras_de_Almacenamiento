/*
 * Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string. Guardar cada uno de esos strings en la posición 0 , 1 y 2. 
 * Mostrar en pantalla en el orden: primero posición 1, después posición 2 y por último posición 0.
 * Pista: 
 * Puedes utilizar un bucle para ir pedir una palabra al usuario e introducirlo en cada una de las posiciones del array.
 */
using System;

namespace _09_Ejercicio_Repaso01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            string[] palabras = new string[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Introduce una palabra");
                palabras[i] = Console.ReadLine();
            }
            for (int i = 0; i <= 2; i++)
            {
                Console.Write(palabras[i]+" ");
            }
        }
    }
}
