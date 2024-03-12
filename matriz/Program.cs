using System;

static class Program
{
    static void Main(string[] args)
    {
        //int[] contarMultiplo= {1,2,3,4,5,6,7,8,9};
        //contarmult(contarMultiplo);
        //contarMultiplo(12345678);
        int nuevoElemento= 10;
        int posicion= 1;
        for(int i =  cambio.Length -1; i > posicion; i--)
        {
            cambio[i] = cambio[i-1];
        }
        cambio[posicion] = nuevoElemento;
        Console.WriteLine("\nVector despues de la insercion");
        imprimirVector(cambio);
    }
    static int[] vectorActual(int[] vector, int[] vectorNuevo, int[] posicion){

    }


//hola



    static void sumarvector(int[] vect)
    {
    int par= 0;
    int impar = 0;
    foreach(int elemento in vect)
    {
        if((elemento % 3) == 0)
        {
        par = par + elemento;
        }
        else{
        impar = impar + elemento;

        }
    
    }
    Console.WriteLine("par: " + par + " impar: " + impar);
    }
    static void contarMultiplo(int numero)
        {
            int contador=0;
            int resultado = 0;
           
            
            while (numero != 0)
            {
                int digito = numero % 10;
                if (digito % 3 == 0)
                {

                    resultado += digito;
                    contador++;
                    
                }
                numero /= 10;
            }
            
            Console.WriteLine("El resultado de los múltiplos de 3 es: " + contador);
        }
     static void contarmult(int[] contarMultiplo)
    {
    int contador=0;
    int resultado = 0;
    foreach(int elemento in contarMultiplo)
    {
        if((elemento % 3) == 0)
        {
        resultado = resultado + elemento;
        contador++;
        }

    
    }
    Console.WriteLine("son : " + contador);
    
}

}

