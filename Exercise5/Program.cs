using System;
using System.Reflection.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        int[] inventory = [10,20,30,40,50];
        int sum =0;
        
        foreach(int i in inventory)
        {
           
            sum = sum + i;
            Console.WriteLine(sum);
            Console.WriteLine(i);
        }    
        
    }
}