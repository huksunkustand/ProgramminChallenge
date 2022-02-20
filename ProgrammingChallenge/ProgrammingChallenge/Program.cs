using ProgrammingChallenge.Configuration;
using ProgrammingChallenge.DAOFactory;
using ProgrammingChallenge.Utils;
using System;

namespace ProgrammingChallenge
{
  class Program
  {
  
    static void Main(string[] args)
    {

      Console.WriteLine("Ingrese los programas a comparar separados por un espacio| Enter the programs to compare separated by a space");
      string words = Console.ReadLine();
      var array = words.CustomSplit();

      if (array.Length >= 2)
      {
        ISearchEngines factory = new SearchEngineConfiguration();
        var services = factory.GetAvailableServices();

        Console.Write("--------------------------------------"); Console.Write("\n");
        foreach (var value in array)
        {
         
          Console.Write($"{ value.Replace("\"", "") }: ");

          foreach (var service in services)
            Console.Write($"{service.GetResults( value.Replace("\"", "") )}" + "|");

          Console.Write("\n");
        }

        Console.Write("--------------------------------------"); Console.Write("\n");
        foreach (var service in services)
        {
          Console.WriteLine(service.WinnerToString());
        }
        Console.Write("--------------------------------------"); Console.Write("\n");

        Console.WriteLine($"Total winner: {factory.GetFinalWinner(services)} ");

        Console.ReadKey();
      }

      Console.WriteLine("Enter at least 2 words separated by space");
    }


  }
}
