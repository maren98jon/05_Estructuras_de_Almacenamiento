/*
 * Crear un array de 11 ints. Pedir al usuario que introduzca valores entre 0 y 10. Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array. 
 * Si por ejemplo introduce un 3, sumar uno a la posición 3. Mostrar en pantalla los valores. Si introduce un número mayor que 10, decir que ese número es incorrecto. 
 * Si introduce un número negativo, mostrar en pantalla el número de cada posición y el valor que contiene. Por ejemplo, si introduce 7, 7, 7, 5, 6, 5, 9, 9, 10, -1 mostrar:
 * 0	
 * 1	0
 * 2	0
 * 3	0
 * 4	0
 * 5	2
 * 6	1
 * 7	3
 * 9	2
 * 10	1
 */
using System;

namespace _13_Ejercicio_Repaso05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código

            int[] cadena = new int[11];
            int numero = 0;

            while (numero >= 0)
            {
                Console.WriteLine("Introduzca un número entre 0 y 10, o uno negativo para acabar.");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero >=0)
                {
                    if (numero <= 10)
                    {
                        cadena[numero]++;
                    }
                    else {
                        
                        Console.WriteLine("Ese número es mayor de 10");
                        Console.WriteLine();
                    }
                }
                
            }
            Console.WriteLine();
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i + "\t" + cadena[i]);
            }
        }
    }
}
