using FNT_BusinessEntities;
using System.Collections.Generic;

namespace FNT_BusinessLogic.Interfaces
{
    public interface IWinner
    {
        IEnumerable<DTOResult> GetSearchEngineWinners(IList<DTOSearchResult> searchData);

        DTOResult GetGrandWinner(IList<DTOSearchResult> searchData);
    }
}
