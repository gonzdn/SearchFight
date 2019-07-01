using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNT_DependencyResolver
{
    public class Searcher
    {
        List<ISearcher> searchers = new List<ISearcher>();

        var config = SearchConfiguration.GetConfig();

            foreach (SearcherElement searcherElement in config.Searchers)
            {
                Type type = Type.GetType(string.Format("{0}, {1}", searcherElement.Type, searcherElement.Namespace));

                if (type != null)
                {
                    Dictionary<string, string> headers = searcherElement.Headers.ToDictionary(k => k.Name, v => v.Value);

        ISearcher searcher = (ISearcher)Activator.CreateInstance(type, searcherElement.Name, searcherElement.Url, headers);

        searchers.Add(searcher);
                }
}

            return searchers;
    }
}
