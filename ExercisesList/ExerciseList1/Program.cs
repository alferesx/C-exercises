using System;

class Program
{
    public static void Main(string[] args)
    {
        /*
        Exercício 1 - Variáveis dentro e fora do bloco
        Crie um método que represente um combate entre um Guerreiro e um Mago.
        Dentro do bloco 'if', declare uma variável chamada 'dano'.
        Tente acessá-la fora do bloco e veja o que acontece
        */
				Program objeto = new Program();
				objeto.IniciarAtaque();
    }

		void IniciarAtaque()
		
		{
			int dano = 15;
			string personagem = "Guerreiro";
			
			if(personagem == "Guerreiro")
			{
				Console.WriteLine($" O {personagem} causou {dano} de dano ");
			}
			Console.WriteLine($"Dano total: {dano} ");
		}
}