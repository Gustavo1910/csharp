using System;

public class teste03
{
     public static void Main ()
    {
     
Console.WriteLine("Insira um valor de 1 a 7: ");
int n = Convert.ToInt32(Console.ReadLine());

   if(n == 1) {
       Console.WriteLine("o número corresponde a domingo.");
   }
   switch(n) {
        case 2:
        Console.WriteLine("o número corresponde a Segunda.");
         break;
          case 3:
        Console.WriteLine("o número corresponde a Terça.");
         break;
          case 4:
        Console.WriteLine("o número corresponde a Quarta.");
         break;
          case 5:
        Console.WriteLine("o número corresponde a Quinta.");
         break;
          case 6:
        Console.WriteLine("o número corresponde a Sexta.");
         break;
          case 7:
        Console.WriteLine("o número corresponde a Sabado.");
         break;
   }
   if(n<1 || n>7){
       Console.WriteLine("Número Invalido");
   }
   }}