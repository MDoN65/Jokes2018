using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using DataAccessLayer;
using System.Data;

namespace SqlLayer
{
    public class JokeSql
    {
        public static DataTable RetrieveJoke(int jokeId)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@id", jokeId, SqlDbType.Int, ParameterDirection.Input));
            return DAL.GetData("getJokeDetails", parms);
        }

        public static DataTable RetrieveJokesByCategory(int catId)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@categoryId", catId, SqlDbType.Int, ParameterDirection.Input));
            return DAL.GetData("getJokesByCategory", parms);
        }

        public static DataTable InsertJoke(IJokes joke)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@Title", joke.Title, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new parameters("@Teaser", joke.Teaser, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new parameters("@JokeText", joke.JokeText, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new parameters("@CategoryId", joke.CategoryId, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new parameters("@Featured", joke.IsFeatured, SqlDbType.Bit, ParameterDirection.Input));
            return DAL.GetData("addJoke", parms);
        }
    }
}
