using System;

class Program
{
    public static void Main(string[] args)
    {
        TurnoDoCombate();
    }

   static void TurnoDoCombate()
    {
        int turno = 5;
        int hpMonstro = 50;
        int hpPlayer = 50;
        int ataquePlayer = 10;
        int ataqueMonstro = 5;

        for(int i = 1; i <= turno;i++)
        {
            Console.WriteLine($"Turno {i}");
            
            Console.WriteLine($"Player atacou o monstro causando {ataquePlayer} de dano");
            
            hpMonstro = hpMonstro - ataquePlayer;
           
            hpPlayer = hpPlayer - ataqueMonstro;
            
            Console.WriteLine($"O monstro ataca o player causando {ataqueMonstro} de dano ");
           
            
            if(hpPlayer == 0)
            {
                Console.WriteLine("Game over você perdeu");
            }
            else
            {
                Console.WriteLine($"O Hp do player atual é {hpPlayer}");
            }
            
            if(hpMonstro == 0)
            {
                Console.WriteLine("Você venceu o monstro foi derrotado.");
            }
            else
            {
                Console.WriteLine($"O Hp do monstro atual é:{hpMonstro}");
            }

        }

    }
}