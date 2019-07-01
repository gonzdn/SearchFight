using FNT_Contracts;
using FNT_Contracts.Models;
using FNT_Services.Interfaces;
using FTN_Common.Helpers;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FNT_Services
{
    public class BingSearch : ISearch
    {
        private HttpClient _client { get; }

        public BingSearch()
        {
            _client = new HttpClient{DefaultRequestHeaders = { { "Ocp-Apim-Subscription-Key", BingContract.ApiKey } } };
        }

        public async Task<long> TotalResults(string query)
        {
            string request = String.Format(BingContract.Url, query);

            using (var response = await _client.GetAsync(request))
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Please try again later.");

                Bing results = JsonHelper.Deserialize<Bing>(await response.Content.ReadAsStringAsync());
                return long.Parse(results.WebPages.TotalEstimatedMatches);
            }
        }
    }
}
