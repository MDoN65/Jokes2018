using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes2018
{


    public class CategoryLookup
    {
        internal CategoryLookup() { }

        public int categoryId { get; internal set; }
        public string categoryName { get; internal set; }

    }

    public class JokesLookup
    {
        internal JokesLookup() { }
        
        public int jokeId { get; internal set; }
        public string title { get; internal set; }
    }


}
