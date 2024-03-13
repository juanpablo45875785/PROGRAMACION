using System;
static class Program{
    static void Main(string[] args)
    {
        //llenarVector(6);
        Console.WriteLine("dame una palabra: ");
        string palabra = Console.ReadLine();
        llenarVectorstring(palabra);
    }
    static void llenarVectorimpar(int cantidad){
        int[] vector = new int[cantidad];
        int numero= 1;
        for(int i=0; i< cantidad; i++){
            while(!esimpar(numero)){
                numero++;
            }
            vector[i]=numero;
            numero++;
        }
        imprimirVector(vector);
    }
    static void llenarVectorPrimo(int cantidad){
        int[] vector = new int[cantidad];
        int numero= 1;
        for(int i=0; i< cantidad; i++){
            while(!esPrimo(numero)){
                numero++;
            }
            vector[i]=numero;
            numero++;
        }
        imprimirVector(vector);
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
    static bool esimpar(int numero){
        if((numero % 2)==1){
            return true;
        }
        else{
            return false;
        }
    }
    static void imprimirVector(int[] vector){
        foreach(int elemento in vector){
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
    static void llenarVectorstring(string palabra){
        
        char[] letras = new char[palabra.Length];
        for( int i= 0; i < palabra.Length;i++){
            letras[i] = palabra[i];
        }
        imprimirVectorletras(letras);
    }
    static void imprimirVectorletras(char[] letras){
        foreach(char letra in letras){
            Console.Write(letra + " ");
        }
        Console.WriteLine();
    }
}
