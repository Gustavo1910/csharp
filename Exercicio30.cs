using System;

public class exercicio01
{
     public static void Main(string[] args)
    {

    Console.WriteLine("Entre com o valor da Base: ");
    int b = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Entre com o valor da Altura: ");
    int h = Convert.ToInt32(Console.ReadLine());

    int a = b*h/2;

    Console.WriteLine("A area do Triangulo: " + a );
    }}

