using System;

namespace Matriz
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*char[,] matriz = CrearMatrizCaracteres(3, 3);
            MostrarMatriz(matriz);*/

            int[,] numeros = CrearMatrizDiagonal(4, 4);
            MostrarMatriz(numeros);

        }
//----------------------------------------------------------------------------------------------------------------------
        static int[,] CrearMatrizPrimos(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];
            int numero = 2;
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    while (!esPrimo(numero))
                        numero++; // Buscamos el próximo número primo
                    matriz[x, y] = numero++;
                }
            }
            return matriz;
        }
        static bool esPrimo(int numero){
        if(numero <= 1){
            return false;
        }
        for(int i = 2; i * i <= numero; i++){
            if(numero % i == 0 ){
                return false;
            }
        }
        return true;
    }
//----------------------------------------------------------------------------------------------------------------------

        static int[,] CrearMatrizPares(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];
            int valor = 2; // Empezamos con el primer número par
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    matriz[x, y] = valor;
                    valor += 2; // Incrementamos en 2 para obtener el siguiente número par
                }
            }
            return matriz;
        }
//----------------------------------------------------------------------------------------------------------------------

         static int[,] CrearMatrizAleatoria(int filas, int columnas)
        {
            Random random = new Random();
            int[,] matriz = new int[filas, columnas];
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    matriz[x, y] = random.Next(20); // Números aleatorios entre 0 y 99
                }
            }
            return matriz;
        }
//----------------------------------------------------------------------------------------------------------------------

        static int[,] CrearMatrizdividido(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];
            int mitad = filas / 2;

            // Rellenar la mitad superior de la matriz diagonal con 2
            for (int x = 0; x < mitad; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    if (x == y)
                        matriz[x, y] = 8;
                    else
                        matriz[x, y] = 8;
                }
            }

            // Rellenar la mitad inferior de la matriz diagonal con 4
            for (int x = mitad; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    matriz[x, y] = 5;
                }
            }

            return matriz;
        }
//----------------------------------------------------------------------------------------------------------------------

        static int[,] CrearMatrizDiagonal(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    if (x == y)
                        matriz[x, y] = 5;

                    else
                        matriz[x, y] = 4;
                }
            }
            return matriz;
        }
//----------------------------------------------------------------------------------------------------------------------

        static int[,] CrearMatrizSecuencial(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];
            int contador = 1;
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    matriz[x, y] = contador++;
                }
            }
            return matriz;
        }
//----------------------------------------------------------------------------------------------------------------------

        static int[,] RellenarMatriz(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];
            int contador = 1; // Valor inicial para rellenar la matriz
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    matriz[x, y] = contador;
                    contador++; // Incrementar el valor para el siguiente elemento
                }
            }
            return matriz;
        }
//----------------------------------------------------------------------------------------------------------------------

        static int[,] CrearMatriz(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas];
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)
                {
                    Console.WriteLine("Ingrese números para la matriz: ");
                    matriz[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matriz;
        }
//----------------------------------------------------------------------------------------------------------------------

        static void MostrarMatriz(int[,] matriz)
        {
            Console.Clear();
            Console.WriteLine("Esta es la matriz llenada: ");
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    Console.Write(" " + matriz[x, y]);
                }
                Console.WriteLine();
            }
        }

        static char[,] CrearMatrizCaracteres(int filas, int columnas, char caracter)
        {
            char[,] matrizstring = new char[filas, columnas];
            for (int x = 0; x < filas; x++)
            {
                for (int y = 0; y < columnas; y++)

                {
                    matrizstring[x, y] = caracter;
                }
            }
            return matrizstring;
        }

        static void MostrarMatriz(char[,] matrizstring)
        {
            for (int x = 0; x < matrizstring.GetLength(0); x++)
            {
                for (int y = 0; y < matrizstring.GetLength(1); y++)
                {
                    Console.Write(matrizstring[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
