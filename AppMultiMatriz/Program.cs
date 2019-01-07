using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMultiMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matrices Multidimensionales Rectagunlares
            int [,]x = new int[3, 3];
            int [,]y = new int[3, 2];
            int [,]z = new int[3, 2];
            leer(x);
            Imprimir(x);

            leer(y);
            Imprimir(y);

            Multi(x, y, z);
            Imprimir(z);

            int[][,] matriz = new int[3][,];
            inicial(matriz);

            Console.ReadKey();
        }
        public static void leer(int[,] matriz)
        {
            Console.WriteLine("Ingre se los elementos de la matriz: ");
            for (int i=0;i<matriz.GetLength(0);i++)
            {
                for (int j = 0; j <matriz.GetLength(1); j++)
                {
                    string aux;
                    Console.Write("[{0}, {1}] ", i, j);
                    aux = Console.ReadLine();
                    matriz[i, j] = Int32.Parse(aux);
                }
                Console.WriteLine();
            }
        }
        public static void Imprimir(int [,] matriz)
        {
            Console.WriteLine("\nImpresion de la matriz");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(" {0} ", matriz[i,j]);
                }
                Console.WriteLine();
            }
        }
        public static void Multi(int [,] A, int[,] B, int[,] C)
        {
            for (int i = 0; i < A.GetLength(0); i++) 
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    C[i,j] = 0;
                    for (int k = 0; k < C.GetLength(0); k++) 
                    {
                        C[i,j] = A[i,j] * B[i,j] + C[i,j];
                    }
                }
            }
        }
        public static void inicial(int [][,] matriz)
        {
            matriz[0] = new int[3, 3];
            matriz[1] = new int[3, 2];
            matriz[2] = new int[3, 2];
            Console.WriteLine("\nMultiplicacion de matrices utilizando dimensiones escalonadas y rectangulares");
            leer(matriz[0]);
            leer(matriz[1]);
            Multi(matriz[0], matriz[1], matriz[2]);
            Imprimir(matriz[2]);
        }
    }
}
