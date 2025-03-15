using System;

class Program
{
    public static void Main(string[] args)
    {
        ComprarItem(50);
    }

    static int ComprarItem(int ouro)
    {
        int precoEspada = 100;
        int quantidadeOuro = 0;
        int quantoFalta = 0;
        if(ouro >= precoEspada)
        {
            quantidadeOuro = ouro - precoEspada;
            Console.WriteLine($"Você comprou uma espada e sua quantidade de ouro restante é de {quantidadeOuro}");
            return quantidadeOuro;

        }else
        {
            quantoFalta = precoEspada - ouro ;
            Console.WriteLine($"Você não possui quantidade de ouro suficiente falta {quantoFalta} de ouro");
            return quantoFalta;
        }
    }
}