using System;


class Program
{
    public static void Main (string[] args)
    {
        Random dice1 = new Random();//Instanciando um objeto Random no primeiro dado.
        
        Random dice2 = new Random();//Instanciando um objeto Random no segundo dado.
        
        Random dice3 = new Random();//Instanciando um objeto Random no terceiro dado.
        
        int valueDice1 = dice1.Next(1,7);//recebendo  o valor no primeiro dado.
        
        int valueDice2 = dice2.Next(1,7);//recebendo o valor no segundo dado.
        
        int valueDice3 = dice3.Next(1,7);//recebendo o valor no terceiro dado.
        
        int score = 0;

        Console.WriteLine($"Valor do Dado1:{valueDice1}");
        
        Console.WriteLine($"Valor do Dado2:{valueDice2}");
        
        Console.WriteLine($"Valor do Dado3:{valueDice3}");
        
        
        if(valueDice1 == valueDice2  && valueDice2 == valueDice3)
        {
            score = valueDice1 + valueDice2 + valueDice3 + 6;
            
            Console.WriteLine($"Os tres dados foram iguais a {valueDice1}");
        }

      
        if(valueDice1 == valueDice2 || valueDice2 == valueDice3 )
         {
                score = valueDice1 + valueDice2 + valueDice3 + 2;
                
                Console.WriteLine($"Você tirou Duplas no primeiro dado com valor: {valueDice1} e segundo dado com o valor:{valueDice2})") ;
         }


        if(score >= 15)
            {
                Console.WriteLine($"You Win with the score of {score}");
            }
            
        else
            {
                Console.WriteLine($"You lose with the score of {score}");
            }

    }

    
}