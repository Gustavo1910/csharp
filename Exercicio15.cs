using System;

public class exercicio01
{
     public static void Main(string[] args)
    {
        Console.WriteLine("Entre com o ano do seu nascimento: ");
        int data = Convert.ToInt32(Console.ReadLine());
       int ano = 2022 - data;

       Console.WriteLine("Sua idade:" + ano);
       if (ano>=18) {Console.WriteLine("E voce pode votar !!");}
       else {Console.WriteLine("E voce NÃO pode votar !!");}
    }
}
