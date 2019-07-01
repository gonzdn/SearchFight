using FNT_BusinessEntities;
using FNT_BusinessLogic.Interfaces;
using FNT_Services;
using FNT_Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FNT_BusinessLogic.Impl
{
    public class SearchProvider : ISearchProvider
    {
        private IList<ISearch> _searchEngines;

        public SearchProvider()
        {
            _searchEngines = GetImplementedSearchEngines();
        }

        private IList<ISearch> GetImplementedSearchEngines()
        {
            GoogleSearch google = new GoogleSearch();
            BingSearch bing = new BingSearch();

            IList<ISearch> engines = new List<ISearch>();

            engines.Add(google);
            engines.Add(bing);

            return engines;
        }

        public async Task<IList<DTOSearchResult>> GetSearchResults(IList<string> terms)
        {
            IList<DTOSearchResult> results = new List<DTOSearchResult>();

            foreach (ISearch engine in _searchEngines)
            {
                foreach (string term in terms)
                {
                    results.Add(new DTOSearchResult
                    {
                        Provider = engine.GetType().Name,
                        Term = term,
                        Results = await engine.TotalResults(term)
                    });
                }
            }

            return results;
        }
    }
}