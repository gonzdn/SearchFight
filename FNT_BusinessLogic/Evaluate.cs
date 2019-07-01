using FNT_BusinessEntities;
using FNT_BusinessLogic.Impl;
using FNT_BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FNT_BusinessLogic
{
    public class Evaluate
    {
        public static List<string> Print { get; private set; }

        static ISearchProvider SearchProvider;
        static IWinner Winner;
        static IPrinter Printer;

        static Evaluate()
        {
            SearchProvider = new SearchProvider();
            Winner = new Winner();
            Printer = new Printer();

            Print = new List<string>();
        }

        public static async Task ExecuteSearchFight(IList<string> terms)
        {
            IList<DTOSearchResult> searchData = await SearchProvider.GetSearchResults(terms);
            IEnumerable<DTOResult> searchEngineWinners = Winner.GetSearchEngineWinners(searchData);
            DTOResult grandWinner = Winner.GetGrandWinner(searchData);

            Print.AddRange(Printer.PrintResults(searchData));
            Print.AddRange(Printer.PrintWinners(searchEngineWinners));
            Print.Add(Printer.PrintTotalWinner(grandWinner));
        }
    }
}
