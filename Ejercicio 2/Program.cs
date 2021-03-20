using System;

namespace Ejercicio_2
{
    class Program
    {
            public static void dibuja(int Cantidad)
            {

                int FF = 20; // Los valores puestos en cada variable se colocaron respetando las condiciones
                int CF = 50; // que se muestran en los for de abajo
                int FI = 8;
                int CI = 9;
                int A, B, C; // Solo cambie el nombre de estas variables porque con estas me guíe para dar forma

                for (C = 1; C <= Cantidad; C++) // C = 1, C es menor o igual que la cantidad, incremento o repetición de C
                {
                    for (A = CI; A <= CF; A++) // A es igual a CI (9), ahora A vale 9, A es menor o igual que CF, CIERTO
                                               // A++ repetición o incremento 
                    {
                        Console.SetCursorPosition(A, FF); Console.Write("?"); // El cursor se posiciona en donde
                        Console.SetCursorPosition(A, FI); Console.Write("?"); // los parametros indican entre ()
                    }
                    for (B = FI; B <= FF; B++) // B es igual a FI (8), ahora B vale 8, B es menor o igual que FF, CIERTO
                                               // B++ repetición o incremento
                    {
                        Console.SetCursorPosition(CI, B); Console.Write("x"); // El cursor se posiciona en donde
                        Console.SetCursorPosition(CF, B); Console.Write("x"); // los parametros indican entre ()
                }
                    FI = FI + 1; // Acá va incrementando o restando según indique para cada cantidad
                    FF = FF - 1;
                    CI = CI + 1;
                    CF = CF - 1;
                }
            }
            static void Main(string[] args)
            {
                for (int tam = 1; tam < 30; tam++) // tam = 1; tam menor que 30, CIERTO, tam++ incremento o repetición
                {                                   // Nota si el valor de FF era mayor a la cantidad con la que se     
                    dibuja(tam);                    // compara tam no corría, esto define el tamaño del dibujo.
                }
            }
        }
    }