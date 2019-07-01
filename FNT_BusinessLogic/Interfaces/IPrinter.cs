using FNT_BusinessEntities;
using System.Collections.Generic;

namespace FNT_BusinessLogic.Interfaces
{
    public interface IPrinter
    {
        IList<string> PrintResults(IList<DTOSearchResult> searchData);
        IList<string> PrintWinners(IEnumerable<DTOResult> engineWinners);
        string PrintTotalWinner(DTOResult grandWinner);
    }
}
