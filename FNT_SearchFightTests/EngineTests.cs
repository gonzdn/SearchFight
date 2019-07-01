using FNT_Services;
using FNT_Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FNT_SearchFightTests
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        public async Task GoogleTest()
        {          
           ISearch _searchEngine;

        IList<ISearch> engines = new List<ISearch>();
            _searchEngine = new GoogleSearch();

            var result = await _searchEngine.TotalResults(".net");

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task BingTest()
        {
            ISearch _searchEngine;

            IList<ISearch> engines = new List<ISearch>();
            _searchEngine = new BingSearch();

            var result = await _searchEngine.TotalResults(".net");

            Assert.IsNotNull(result);
        }
    }
}
