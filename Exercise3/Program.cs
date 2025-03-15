using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;
        
        if(daysUntilExpiration > 5 && daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon.Renew now!");
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} ");
            
        }

        if(daysUntilExpiration > 1 && daysUntilExpiration <=5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} ");
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine("Renew now and save 10%");
        }

        if(daysUntilExpiration == 1)
        {

            Console.WriteLine($"Your subscription expires in {daysUntilExpiration}");
            Console.WriteLine("Your subscription expires within a day");
            Console.WriteLine("Renew now and save 20%");
        }
        
        else
        {
            Console.WriteLine("Your subscription has expired");
        }
    }
}