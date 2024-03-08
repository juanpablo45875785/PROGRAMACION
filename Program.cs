using System;

static class Program
{
    static void Main(string[] args)
    {

        //hdmi
        //Console.WriteLine("Ingrese su primera nota: ");
        //int nota1 = int.Parse(Console.ReadLine());

       // Console.WriteLine("Ingrese su segunda nota: ");
        //int nota2 = int.Parse(Console.ReadLine());

       // EvaluarNota(nota1, nota2);
        rotar();
        Console.ReadLine();
    }
    static void rotar(){
        string numero = Console.ReadLine();
        char primero = numero[0];
        char segundo = numero[1];
        string resto = numero.Substring(2, numero.Length - 2);
        string resultado = resto + segundo + primero;
        Console.WriteLine(resultado);
    }

    static void EvaluarNota(int nota1, int nota2)
    {
        int promedio = (nota1 + nota2) / 2;

        if (promedio > 50)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
    
}