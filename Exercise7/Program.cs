using System;


class Program

{

	
	public  int PopulationCounter {get; set;} = 0;
	
	public string Name {get;set;}

	
	public Program (string name)
	
	{
		
		Name = name;
		
		PopulationCounter++;
	} 
    
		public static void Main(string[] args)
    
		{
			
			Program p1 = new Program("Call");
			
			Program p2 = new Program("Rob");
			
			Program p3 = new Program("Alex");
			
			Console.WriteLine(p1.Name);
			
			Console.WriteLine(p2.Name);
			
			Console.WriteLine(p3.Name);
			
			Console.WriteLine(p1.PopulationCounter);
			
			Console.WriteLine(p2.PopulationCounter);
			
			Console.WriteLine(p3.PopulationCounter);
    }
}
