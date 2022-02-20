using ProgrammingChallenge.DAOFactory;
using ProgrammingChallenge.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingChallenge.Configuration
{
  class SearchEngineConfiguration : ISearchEngines
  { 
    public SearchService[] GetAvailableServices()
    {
      return new SearchService[] {
                new GoogleService(),
                new BingService()
            };
    }

    public string GetFinalWinner(SearchService[] services)
    {
      var winners = new List<string>();
      foreach (var service in services) winners.Add(service.GetWinner());
      return winners.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
    }

  }
}
