using System;
using System.Collections;

class Program
{
	public static void Main(string[] args)
	{
		string[] listaAlunos = ["Pedro","Carlos","Alana","Sarah"];
		
		int[] notasPedro = new int[] {90, 86, 87, 98, 100};
		
		int[] notasCarlos = new int[] {20,30,0,50,80};
		
		int[] notasAlana = new int[] {80,90,90,100,100};
		
		int[] notasSarah = new int[] {100,100,100,100,100};

		
		double mediaAlunoPedro = CalcularMedia(notasPedro);
		double mediaAlunoCarlos = CalcularMedia(notasCarlos);
		double mediaAlunaAlana = CalcularMedia(notasAlana);
		double mediaAlunaSarah = CalcularMedia(notasSarah);
		
		Console.WriteLine("Student        Grade");
		
		Console.WriteLine("########################################################################");
		
		Console.WriteLine($"{listaAlunos[0]}          {mediaAlunoPedro}     {MostrarMedia(mediaAlunoPedro)}  ");
		
	//	Console.WriteLine($"{listaAlunos[1]}         {mediaAlunoCarlos}     {MostrarMedia(mediaAlunoCarlos)}  ");
		
	//	Console.WriteLine($"{listaAlunos[2]}          {mediaAlunaAlana}     {MostrarMedia(mediaAlunaAlana)}  ");
		
	//	Console.WriteLine($"{listaAlunos[3]}          {mediaAlunaSarah}    {MostrarMedia(mediaAlunaSarah)}  ");

	}

	static public double CalcularMedia(int[]array)
	{
		double media;
		
		double soma = 0;

		foreach(int n in array)
		{
			//double  trabalhoExtra = n * 0.1;
			soma =  soma + n  ;
		}
			
		return soma/ array.Length;
	}

	static string  MostrarMedia( double media)
	{
		switch(media)
		{
			case double nota when (nota >= 96):return "A+";
			case double nota when (nota >=93 ):return "A";
			case double nota when(nota >=90 ):return "A-";
			case double nota when(nota >= 87):return "B+";
			case double nota when(nota >= 83):return "B";
			case double nota when(nota >= 80):return "B-";
			case double nota when (nota >= 77):return "C+";
			default:return "C-";
		}

	}
	
}