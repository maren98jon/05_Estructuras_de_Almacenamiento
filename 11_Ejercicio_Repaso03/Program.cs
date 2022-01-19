/*
 * Poner los nombres de los meses en un array de 12. Cuando el usuario introduce un número del 1 al 12, mostrar el nombre de ese mes en pantalla.
 */
using System;

namespace _11_Ejercicio_Repaso03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduce aquí tu código
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Console.WriteLine("Introduzca un número para saber a que mes pertenece:");
            int numero = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine(meses[numero]);
            
        }
    }
}
