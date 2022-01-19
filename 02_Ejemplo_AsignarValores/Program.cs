/*
 * Al igual que podemos acceder a un valor del array, también podemos asignarle un valor o modificar el valor de una posición
 */
using System;

namespace _02_Ejemplo_AsignarValores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Primero declaramos el array y definimos el número de valores que va a almacenar, en este caso 3 valores.
             * Todavía en este momento no le hemos asignado ningún valor, simplemente hemos creado un array con 3 posiciones.
             * 
             * Entonces, ¿Esas posiciones están vacías? 
             * NO, cuando creamos un array y determinamos el número de valores que va a almacenar  no le  estamos asignando valores a esas posiciones, simplemente
             * creándolas. A las posiciones creadas a las que no se les ha asignado ningún valor, por defecto se les asigna un valor de 0  si se trata de un array de int 
             * y “ “ un string vacío si se trata de un array de string. 
             * 
             * Para comprobarlo, vamos a crear un array con 3 posiciones y vamos a mostrar el valor de dichas posicones antes de asignarle valores y después. 
             */

            int[] notasAlumnos = new int[3];

            /*
             * Almacenamos el valor de cada posición en una variable cuyo nombre coincide con la posición que ocupa
             */
            int posicion0 = notasAlumnos[0];
            int posicion1 = notasAlumnos[1];
            int posicion2 = notasAlumnos[2];

            /*
             * después mostramos por pantalla el valor de cad auna de las posiciones del array 
             */

            Console.WriteLine(posicion0);
            Console.WriteLine(posicion1);
            Console.WriteLine(posicion2);


            //Después, asignamos a cada una de las posiciones un valor

            notasAlumnos[0] = 5; //Asignamos a la posición 0 el valor 5
            notasAlumnos[1] = 8; //Asignamos a la posición 1 el valor 8
            notasAlumnos[2] = 10; //Asignamos a la posición 2 el valor 10

            //Por último, mostramos por consola el valor de cada una de las posiciones
            Console.WriteLine(notasAlumnos[0]);
            Console.WriteLine(notasAlumnos[1]);
            Console.WriteLine(notasAlumnos[2]);
        }
    }
}
