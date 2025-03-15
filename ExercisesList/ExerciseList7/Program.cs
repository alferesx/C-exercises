using System;

class Program
{
    public static void Main(String[] args)
    {
        string[] inventario = new string[] {"pocao","espada","escudo"};

        MostrarInventario(inventario);
    }

   static void MostrarInventario(string[] array)
    {
        foreach(string i in array)
        {
            Console.WriteLine(i);
        }
    }
}