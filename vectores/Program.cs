using System; 
static class Program
{
    static void Main(string[]args)
    {
    /*int[] numero = new int[] {1,2,3,4,5,6};
    char[] letra = new char[] {'a','b','c','d','e'};
    string[] palabra = new string[] {"hola","mundo","es","genial"};
    int[] vacio = new int[6];
    Console.WriteLine("\nVector vacio: ");*/
    int[] numero = {1,2,3,4,5,6,7,8};
    //numero[2] = 300;
    //cambioVector();
    procedimiento(cambio);
    }
    static void procedimiento(int[] cambio)
    {
        
        int[] tem = cambio[3];
        cambio[3] = cambio[2];
        cambio[3]=tem[2];
    }
    static void cambioVector(){
        int[] numero = {1,2,3,4,5,6,7,8};
        imprimirvector(numero);
        numero[2] =100;
        imprimirvector(numero);


    }
    static void imprimirvector(int[] vector)
    {
        string vectorString = " ";
        foreach(int elemento in vector)
        {
            vectorString = vectorString + elemento + " ";
        }
        Console.WriteLine(vectorString);

    }
}


