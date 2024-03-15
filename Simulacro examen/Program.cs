using System;

namespace Simulacro
{
    static class Program
    {
        static void Main(string[] args)
        {
        //int[,] numeros = GenerarMatrizPatron(7, 5);
        //ImprimirMatriz(numeros);
        //FiltrarNumerosPrimos(107099057);
        /*Console.WriteLine("Ingrese una oración:");
        string oracion = Console.ReadLine();
        
        int cantidadPalabras = ContarPalabras(oracion);

        Console.WriteLine("La cantidad de palabras en la oración es: " + cantidadPalabras);*/

        int[] vector = {4,5,1,2,2,2,2,5,7,1,2};
        int a=4;
        int b=7;
        Console.WriteLine(SumaElementosEnRango(vector, a, b));



        }
        static int SumaElementosEnRango(int[] vector, int a, int b)
        {
        int sumaDentro = 0;
        int sumaFuera = 0;
        foreach (int elemento in vector)
        {
            if (elemento >= a && elemento <= b)
            {
                sumaDentro += elemento;
            }
            else
            {
                sumaFuera += elemento;
            }
        }
        return sumaDentro - sumaFuera;
        }

        static bool TodosElementosEnRango(int[] vector, int a, int b)
        {
        foreach (int elemento in vector) // Iteramos sobre cada elementodel vector
        {
        if (elemento >= a && elemento <= b) // Verificamos si el elemento está fuera del rango [a, b]
        {
        return false; // Si encontramos un elemento fuera del rango, devolvemos false
        }
        }
        return true; // Si todos los elementos están dentro del rango, devolvemos true al final del bucle
        }

        static int[,] GenerarMatrizPatron(int filas, int columnas)
        {
        int[,] matriz = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = (i + 0) + (j + 1);
            }
        }
        return matriz;
        }
        static int ContarElementosEnRango(int[] vector, int a, int b)
    {
        int contador = 0;
        foreach (int elemento in vector)
        {
            if (elemento >= a && elemento <= b)
            {
                contador++;
            }
        }
        return contador;
    }

        static int ContarPalabras(string oracion)
    {
        // Dividir la oración en palabras utilizando los espacios como separadores
        string[] palabras = oracion.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Retornar la cantidad de palabras obtenidas
        return palabras.Length;
    }
    static void ContarVocales()
    {
    Console.WriteLine("Introduzca una Oracion: ");
    string palabra = Console.ReadLine().ToLower(); //minuscula la palabras
    int conteoVocales = 0;
    // mide loq hay en la palabra
    for (int i = 0; i < palabra.Length; i++)
    {
        if (" ".Contains(palabra[i])) //hace el conteo
        {
            conteoVocales++; // Incrementar el contador si el caracter es una vocal
        }
    }
    Console.WriteLine("La cantidad de vocales en la oracion es: " + conteoVocales);
    Console.ReadKey();
    }
    
    static void FiltrarNumerosPrimos(int numero)
    {
        int resultado = 0;
        int potencia = 1;

        while (numero != 0)
        {
            int digito = numero % 10;

            if (EsPrimo(digito))
            {
                resultado += digito * potencia;
                potencia *= 10;
            }

            numero /= 10;
        }

        Console.WriteLine(resultado);
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

        static void ImprimirMatriz<T>(T[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
