using System;
using System.Net.Http;
using System.Threading.Tasks;
using FNT_Contracts;
using FNT_Services.Interfaces;
using FTN_Common.Helpers;

namespace FNT_Services
{
    public class GoogleSearch : ISearch
    {
        private HttpClient _client { get; }

        public GoogleSearch()
        {
            _client = new HttpClient();
        }

        public async Task<long> TotalResults(string query)
        {
            string request = String.Format(GoogleContract.Url, GoogleContract.Key, GoogleContract.ContextId, query).Replace(';','&');               

            using (var response = await _client.GetAsync(request))
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Please try again later.");

                Google results = JsonHelper.Deserialize<Google>(await response.Content.ReadAsStringAsync());
                return long.Parse(results.searchInformation.totalResults);
            }
        }
    }
}
