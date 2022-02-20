using ProgrammingChallenge.DAOFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingChallenge.Services
{
   abstract class SearchService
  {
    public abstract ISearchEngine CreateEngine();
    public abstract string NameWords { get; }
    private string Winner = "Sin resultados";
    private int WinnerResults = 0;

    public string GetWinner()
    {
      return Winner;
    }

    public string WinnerToString()
    {
      return $"{NameWords} winner : {Winner}";
    }
    private void SetWinner(string word, int results)
    {
      if (results > WinnerResults)
      {
        Winner = word;
        WinnerResults = results;
      }
    }
    public string GetResults(string word)
    {
      var engine = CreateEngine();

      var results = engine.Search(word);

      SetWinner(word, results);

      return $"{NameWords} : {results}";
    }



  }

}
