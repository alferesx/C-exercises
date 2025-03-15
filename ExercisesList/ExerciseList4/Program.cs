using System;

class Program
{
    public static void Main(string[] args)
    {
        DefinirPocoes();
    }

    static void DefinirPocoes()
    {
        bool naoEstaDefinindo = true;
        
        string quantidadePocoesInput = "";
        
        string resposta = "";
        
        while(naoEstaDefinindo){
        
        try
        {
            Console.WriteLine("Digite a quantidade de pocoes que você deseja: ");
            
            quantidadePocoesInput =  Console.ReadLine();
            int input = int.Parse(quantidadePocoesInput);
            
            Console.WriteLine("Deseja continuar definindo suas poções?");
            
            resposta = Console.ReadLine();
            
            if( resposta == "nao" || resposta == "Nao" )
            {
                naoEstaDefinindo = false;
            }
        
        }
            catch(FormatException e )
            {
                Console.WriteLine(e.Message + "Digite valores inteiros");
            }
        }
    }
}
