using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escolha a sua classe");
        EscolherClasse(1);
    }

   static int EscolherClasse(int codigo)
    {
        string classe = "";
        if(codigo == 1)
        {
            classe = "Guerreiro";
            Console.WriteLine($"Você Escolheu a classe {classe}");
        }
       else if(codigo == 2)
        {
            classe = "Mago";
            Console.WriteLine($"Você Escolheu a classe {classe}");
        }

       else if(codigo == 3)
        {
            classe = "Arqueiro";
            Console.WriteLine($"Você Escolheu a classe {classe}");
        }
        else
        {
            Console.WriteLine("Você escolheu uma classe secreta");
        }
        return codigo;
    }
}