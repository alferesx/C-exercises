using System;

class Program
{
    public static void Main(string[] args)
    {
        CalcularDano(0);
    }

    public static int CalcularDano(int nivel)
    {
        int danoBase = 0;
        if(nivel >= 11)
        {
            danoBase = 30;
            Console.WriteLine($"O seu dano base vai ser: {danoBase} ");
        }
        else if(nivel >= 6)
        {
            danoBase = 20;
            Console.WriteLine($"O seu dano base vai ser:{danoBase}");

        }else if(nivel >= 1)
        {
            danoBase = 10;
            Console.WriteLine($"O seu dano base vai ser: {danoBase}");
        }else
        {
            Console.WriteLine("Valor inexistente");
        }

        
        return danoBase;
    }
}