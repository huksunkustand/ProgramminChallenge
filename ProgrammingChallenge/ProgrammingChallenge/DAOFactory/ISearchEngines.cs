using ProgrammingChallenge.Services;

namespace ProgrammingChallenge.DAOFactory
{
  interface ISearchEngines
  {
    SearchService[] GetAvailableServices();
    string GetFinalWinner(SearchService[] services);
  }

  public interface ISearchEngine
  {
    int Search(string word);
  }

}
