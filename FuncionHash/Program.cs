using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionHash
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 8, 11, 14, 17, 20, 23, 26, 29, 32 };
            int valor;
            int funcion;
            char resp;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("    Busqueda por Interpolacion");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < arr.Length; i++)
                    Console.WriteLine("[{0}] {1} ", i, arr[i]); //Se imprime el arreglo

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nQue elemento desea buscar?: ");
                valor = Int32.Parse(Console.ReadLine());

                funcion = (valor - 5) / 3; //Funcion Hash del arreglo que devuelve la posicion del elemento buscado

                if (funcion < 0 || funcion > arr.Length - 1)  //Si el valor de la funcion se sale del indice el elemento no existe
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEl elemento no se encuentra en el arreglo");
                }
                else
                {
                    if (arr[funcion] == valor) //Comprobacion si el indice es igual al valor ingresado para evitar errores
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nEl elemento se encuentra en la posicion [{0}]", funcion);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEl elemento no se encuentra en el arreglo");
                    }

                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nDesea realizar otra busqueda? (s/n): ");
                resp = char.Parse(Console.ReadLine());

            } while (resp == 's' || resp =='S');
        }
    }
}
