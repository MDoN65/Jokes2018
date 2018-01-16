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
        public static DataTable RetrieveJoke(IJokes joke)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@id", joke.jokeId, SqlDbType.Int, ParameterDirection.Input));
            return DAL.GetData("getJokeDetails", parms);
        }
    }
}
