using ProgrammingChallenge.BussinesLogic;
using ProgrammingChallenge.DAOFactory;

namespace ProgrammingChallenge.Services
{
  class GoogleService : SearchService
  {
    public override string NameWords => "Google";

    public override ISearchEngine CreateEngine()
    {
      return new GoogleEngineBL();
    }

  }
}
