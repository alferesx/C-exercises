using System;

class Program
{
    public static void Main(string[] args)
    {
       /*
        string[] fraudulentOrderIDS = new string[3];
       
        fraudulentOrderIDS[0] = "A123";
       
        fraudulentOrderIDS[1] = "B456";
       
        fraudulentOrderIDS[2] = "C789";
        */
        
        string[] fraudulentOrderIDS = ["A123","B456","C789"];
        
        Console.WriteLine(fraudulentOrderIDS[0]);
        
        Console.WriteLine(fraudulentOrderIDS[1]);
        
        Console.WriteLine(fraudulentOrderIDS[2]);
        
        fraudulentOrderIDS[0] = "F000";
        
        Console.WriteLine(fraudulentOrderIDS[0]);
        Console.WriteLine(fraudulentOrderIDS.Length);

        foreach(string fraud in fraudulentOrderIDS)
        {
            Console.WriteLine(fraud);
        }
    }
}