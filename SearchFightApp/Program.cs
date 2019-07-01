using FNT_BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNT_SearchFightApp
{
    class Program
    {
        static void Main(string[] args) 
        {

#if (DEBUG)
            args = new[] { ".net", "java" };
#endif            

            Console.WriteLine("Searching..");
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            await Evaluate.ExecuteSearchFight(args.ToList());
            Evaluate.Print.ForEach(report => Console.WriteLine(report));
            Console.ReadLine();
        }
    }
}
