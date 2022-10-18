using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {// Pila : Estructura Lifo ( El ultimo en entrar , el primero en salir
            string palabra;
            Stack colaPalabras = new Stack();
            Console.WriteLine("Ingrese la  palabra");
            palabra = Console.ReadLine();
            while (palabra != "")
            {
                colaPalabras.Push(palabra);
                Console.WriteLine("Ingrese la próxima palabra");
                palabra = Console.ReadLine();
            }
            while (colaPalabras.Count > 0)
            {
                Console.WriteLine((string)colaPalabras.Pop());
            }
            Console.ReadKey();
        }
    }
}
