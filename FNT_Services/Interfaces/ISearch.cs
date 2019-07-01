using System.Threading.Tasks;

namespace FNT_Services.Interfaces
{
    public interface ISearch
    {        
        Task<long> TotalResults(string query);
    }
}