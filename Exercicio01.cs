using System;
 
 public class Exercicio01
{

    public static void Main (string[] args)
    {
        
		Console.WriteLine("Insira o valor da primeira nota do aluno");
        double n1 =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o valor da segunda nota do aluno");
         double n2 =Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o valor da terceira nota do aluno");
        double n3 = Convert.ToDouble(Console.ReadLine());
        
         Console.WriteLine("Insira o valor da quarta nota nota do aluno");
         double n4 = Convert.ToDouble(Console.ReadLine());

         double media= (n1 + n2 + n3 + n4)/4;

       if (media >= 8.5 ){Console.WriteLine("Aprovado, sua media é: " +media);}
		else if (media < 8.5 && media > 6.0){Console.WriteLine("Exame, media é: " +media);}
		else if (media <= 6.0){Console.WriteLine("Retido,sua media é: " +media);}
		
	}}
    