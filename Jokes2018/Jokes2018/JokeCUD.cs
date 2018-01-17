using SqlLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes2018
{
    public static class CUDMethods
    {
        public static bool Add(Joke joke)
        {
            return JokeSql.InsertJoke(joke);
        }

        public static bool Update(Joke joke)
        {
            return JokeSql.UpdateJoke(joke);
        }
    }
}