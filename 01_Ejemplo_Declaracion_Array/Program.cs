/*
 * Para declarar un array se requiere el tipo de dato, los elementos a almacenar y un nombre para el array.
 */
using System;

namespace _01_Ejemplo_Declaracion_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Para declarar un array primero indicamos el tipo de dato (string). Después utilizamos los corchetes [ ] para indicar 
             * que la variable que estamos declarando va a ser un array. Y por último, al igual que con el resto de variables le debemos asignar un nombre.
             * 
             * Para asignar los valores, utilizamos las llaves{ }entre las cuales introducimos los valores que queremos que
             * formen parte de nuestro array separados por comas ( , ).
             */
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            /*Otra forma es declarando primero el array, y a continuación indicando el número de valores que va a almacenar. 
             * Para ello se especifica el número de elementos entre corchetes[] y a través del operador new junto con el tipo de dato de nuevo:
             */
            string[] mesesAnio;
            mesesAnio = new string[12];

            //También se puede hacer directamente:
            //string[] mesesAnio = new string[12];

            /*En este caso, indicamos el número de valores que va a almacenar el array pero todavía no 
             * le hemos asignado ningún valor.Veremos como podemos asignarle valores a continuación.*/


            /*Cada uno de los valores tiene una posición dentro del array, las posiciones van desde 0 hasta su longitud menos 1. 
             * Es decir, “Enero” estaría en la posición 0 dentro del array meses, “Febrero” en la posición 1, “Marzo”  en la posición 2, 
             * “Abril” en la posición 3… y así hasta “Diciembre” que estaría en la posición 11. Sin embargo, “mes” tendría 12 valores. 
             * 
             * Cuando queremos acceder a un valor, lo hacemos a través de su posición. 
             * acceder a “Enero” primero indicamos el nombre de la variable que almacena el array, meses, y entre corchetes la 
             * posición que ocupa el valor que queremos obtener --> meses[0];.
             */
            string enero = meses[0];

            //Una vez hemos obtenido el valor, podemos asignarlo a otra variable o mostrarlo directamente por consola

            Console.WriteLine(enero);

            Console.WriteLine(meses[1]);
         

        }
    }
}