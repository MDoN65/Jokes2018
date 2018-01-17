using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlLayer;

namespace Jokes2018
{
    public class JokeFactory
    {
        public static Joke Create()
        {
            return new Joke();
        }

        public static Joke Create(int jokeId)
        {
            DataTable tmpTable = JokeSql.RetrieveJoke(jokeId);
            return Repackage(tmpTable.Rows[0]);
        }

        private static Joke Repackage(DataRow myRow)
        {
            Joke joke = new Joke();
            joke._jokeId = Convert.ToInt32(myRow["id"]);
            joke._title = myRow["title"].ToString();
            joke._teaser = myRow["teaser"].ToString();
            joke._jokeText = myRow["joke_text"].ToString();
            joke._categoryId = Convert.ToInt32(myRow["category_id"]);
            joke._isFeatured = Convert.ToBoolean(myRow["featured"].ToString());
            joke._timestamp = myRow["timestamp"]; 

            return joke;
        }
    }
}