using System;

class Program
{
    public static void Main(String[] args)
    {
        Random dice = new Random();
        
        int roll1 = dice.Next(1,7);
        
        int roll2 = dice.Next(1,7);
        
        int roll3 = dice.Next(1,7);
        
        int total = roll1 + roll2 + roll3;
        
        Console.WriteLine(total);
        
        if(roll1 == roll2 && roll2 == roll3)
        {
            total+=6;
            Console.WriteLine($"O total foi: {total}");
        }
        
        if(roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
        {
            total+=2;
            Console.WriteLine($"Total de pontos:{total}");
        }

        if(total >= 10)
        {
            Console.WriteLine("You win a Car and a new Laptop");
        }

        if(total == 7)
        {
            Console.WriteLine("The player wins a trip and a kitten");
        }
        
        
    }
}