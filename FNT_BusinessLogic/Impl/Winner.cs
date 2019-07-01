using FNT_BusinessEntities;
using FNT_BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FNT_BusinessLogic.Impl
{
    public class Winner : IWinner
    {
        public DTOResult GetGrandWinner(IList<DTOSearchResult> searchData)
        {
            DTOSearchResult searchWinner = searchData.OrderByDescending(i => i.Term).First();
            return new DTOResult() { Provider = searchWinner.Provider, Term = searchWinner.Term };
        }

        public IEnumerable<DTOResult> GetSearchEngineWinners(IList<DTOSearchResult> searchData)
        {
            IEnumerable<DTOResult> searchEngines = searchData.GroupBy(data => data.Provider,
                result => result, (searchEngine, results) => new DTOResult
                {
                    Provider = searchEngine,
                    Term = results.Max(item => item.Term).ToString()
                });

            return searchEngines;
        }
    }
}
