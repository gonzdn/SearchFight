using FNT_BusinessEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FNT_BusinessLogic.Interfaces
{
    public interface ISearchProvider
    {
        Task<IList<DTOSearchResult>> GetSearchResults(IList<string> terms);
    }
}
