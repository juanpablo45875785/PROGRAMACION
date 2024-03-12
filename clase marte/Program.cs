using System;
static class Program{
    static void Main(string[] args)
    {
        llenarVector(6);
    }
    static void llenarVector(int cantidad){
        int[] vector = new int[cantidad];
        int numero= 1;
        for(int i=0; i< cantidad; i++){
            while(!espar(numero)){
                numero++;
            }
            vector[i]=numero;
            numero++;
        }
        imprimirVector(vector);
    }
    static bool espar(int numero){
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
    
}
