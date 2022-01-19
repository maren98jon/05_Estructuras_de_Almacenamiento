﻿/*
 * En el caso que hemos visto anteriormente sólo teníamos 3 elementos en nuestro array, pero si tuviéramos 20 elementos y quisiéramos mostrar por consola 
 * todos sus valores, resultaría bastante tedioso tener que estar haciendo un Console.WriteLine() por cada una de las posiciones.
 * Para evitarlo podemos utilizar un bucle for y aprovecharnos de cada vuelta del bucle para mostrar por consola el valor de cada una de las posiciones del array. 
 * ¿Cómo haremos esto?
 */
using System;

namespace _05_Ejemplo_RecorrerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animales = { "perro", "lobo", "gato", "tiburón", "rana" }; //Primero creamos el array con los valores que queramos 

            /*
             * Lo más importante es observar y tener en cuenta las características de nuestro array, principalmente nº de posiciones (5), 
             * y posiciones que tiene por consiguiente (0,1,2,3,4) en este caso. ¿Por qué debemos tener esto en cuenta?
             * 
             *          - El nº de posiciones nos indica el número de vueltas que tiene que dar el bucle. Si hay 5 valores el bucle deberá ejecutarse 
             *          5 veces para mostrar cada uno de los valores. 
             *          
             *          - Las posiciones nos van a servir para conocer con que valor debemos inicializar la variable (i) y que condición debemos definir.
             *          
             *Inicializamos la variable ‘i’ en 0  puesto que la primera posición del array es 0. Después definimos la condición, la instrucción que se encuentra 
             *entre los corchetes del bucle ( Console.WriteLine(animales[i]);) se va a seguir ejecutando mientras i sea menor que 5. Y por último por cada vuelta 
             *incrementamos el valor de ‘i’ en 1. De esta manera ‘i’ por cada vuelta irá incrementando su valor, desde 0,1,2,3,4 (correspondiendo el valor de i con 
             *las posiciones del array) hasta que su valor sea 5, entonces la condición no se va a cumplir ya que 5 NO es menor que 5 y, por lo tanto, saldremos del bucle. 
             */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(animales[i]);
            }

        }
    }
}
