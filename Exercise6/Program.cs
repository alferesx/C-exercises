using System;

class Program
{
    public static void Main(string[] args)
    {
        //1-criar um array
        //2-criar um contador de fraude
        //3-Pecorrer o meu array
        //4-Fazer uma condição dentro do array para verificar se algum orderID contem uma letra B
        //5-Caso tenha aumentar o contador de fraude;

        string [] orderID = ["B123","C234","A345","C15","B177","G3003","C235","B179"];
        
        int fraudCount = 0;
        
        Console.WriteLine("As fraudes encontradas foram: ");
        foreach( var id in orderID)
        {
            if(id.StartsWith("B"))
            {
                fraudCount++;
                Console.WriteLine(id);
            }
        }

        Console.WriteLine($"Total: {fraudCount} dentro dessa orderID ");
    }   	
}