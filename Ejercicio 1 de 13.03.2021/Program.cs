using System;
using System.Threading;

namespace Ejercicio_1_de_13._03._2021
{
    class Program
    {
        public static string Mid(string parametro, int startindex, int length)
        {
            string Resultado = parametro.Substring(startindex, length); // parametro para la subcadena
            return Resultado; // devuelve un valor
        }
        static void Main(string[] args)
        {
            string Nombre;
            string RFinal;
            int i = 0;
            int y = 0;
            int TamanioNombre = 0;
            int X = 0;
            Console.Write("Ingrese su nombre:"); // Ingresa el nombre el usuario
            Nombre = Console.ReadLine(); // Lo lee 
            Console.SetCursorPosition(12,12); // El cursor se posiciona en ese lugar
            Console.Write(Nombre); // Muestra el nombre 
            TamanioNombre = Nombre.Length; // Tamaño del nombre convertido a numero
            X = 1;
            Nombre = Nombre.ToUpper();  // To.Upper lo pasa a mayusculas 
            for (y = Nombre.Length; y >= 1; y--) // y es igual a el numero de caracteres, y mayor que 1, y--
            {
                RFinal = Mid(Nombre, y - 1, 1); // Aca nos va devolver un string la función Mid
                for (i = TamanioNombre; i <= X; i++) ; // i es igual al numero de caracteres, i es menor que x que tiene valor de 1, incremento de i
                {
                    Console.SetCursorPosition(i,10); // Lugar en el que se colocará el cursor, se pone en un inicio i porque i es el tamaño del nombre
                    Console.Write(" " + RFinal); // Mostramos en pantalla la respuesta final, en este caso ya mostramos el nombre en mayusculas
                    Thread.Sleep(50); // Mini pausas para que se vea como lo realiza
                }
                X--; 
                TamanioNombre--;

            }
        }
    }
}
