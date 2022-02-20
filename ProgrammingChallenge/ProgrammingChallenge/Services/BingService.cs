using ProgrammingChallenge.BussinesLogic;
using ProgrammingChallenge.DAOFactory;

namespace ProgrammingChallenge.Services
{
  class BingService : SearchService
  {
    public override string NameWords => "Bing";
    public override ISearchEngine CreateEngine()
    {
      return new BingEngineBL();
    }

  }
}
