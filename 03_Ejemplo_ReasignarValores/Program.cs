/*
 * A la hora de asignar un valor tenéis que tener en cuenta que al declarar el array indicamos el número de posiciones, valores que este va a almacenar. 
 * Si intentamos ampliar ese número, es decir, almacenar un valor más del que indicábamos inicialmente,  el programa nos dará error. 
 * Lo que sí podemos hacer es modificar un valor del array.
 */
using System;

namespace _03_Ejemplo_ReasignarValores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Primero declaramos el array y le asignamos los valores que queramos. En este caso hemos asignado los valores a la vez que declaramos el array. 
             * El array notas, es un array que almacena valores int, en concreto 3 valores int, que son los que le hemos asignado inicialmente.
             * 
             * Como comentábamos anteriormente una vez creado el array, podemos modificar el valor de alguna o todas las posiciones, pero nunca podremos 
             * añadirle una posición más, es decir, este array notas siempre va a almacenar 3 valores int, puedes ir modificando esos valores pero siempre serán 3. 
            */

            int[] notas = { 5, 8, 10 };

            /*
             * Para reasignar, y así modificar el valor de alguna de las posiciones utilizamos la misma sintaxis que cuando asignamos inicialmente un valor a una posición, 
             * al final, es lo que estamos haciendo. Para ello indicamos el nombre del array, entre corchetes la posición del valor que queremos modificar 
             * seguido del símbolo de asignación “=” y el nuevo valor que queremos asignarle.
             */

            notas[2] = 5;

            /*
             * Por úlitmo, mostramos por consola el valor de la posición.
             */

            Console.WriteLine(notas[2]);
        }
    }
}
