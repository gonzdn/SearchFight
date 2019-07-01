using FNT_BusinessEntities;
using FNT_BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FNT_BusinessLogic.Impl
{
    public class Printer : IPrinter
    {
        public IList<string> PrintResults(IList<DTOSearchResult> searchData)
        {

            return searchData.GroupBy(item => item.Term)
                .Select(group => $"{group.Key}: {string.Join(" ", group.Select(item => $"{item.Provider}: {item.Results}"))}")
                .ToList();
        }

        public string PrintTotalWinner(DTOResult grandWinner)
        {
            StringBuilder grandWinnerBuilder = new StringBuilder();
            grandWinnerBuilder.Append("Total winner: ");
            grandWinnerBuilder.Append(grandWinner.Provider);
            return grandWinnerBuilder.ToString();
        }

        public IList<string> PrintWinners(IEnumerable<DTOResult> engineWinners)
        {
            List<string> results = new List<string>();

            foreach (DTOResult winner in engineWinners)
            {
                StringBuilder winnerBuilder = new StringBuilder();
                winnerBuilder.Append(winner.Provider + " winner : ");
                winnerBuilder.Append(winner.Term);
                results.Add(winnerBuilder.ToString());
            }

            return results;
        }
    }
}
