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
    public class CategorySql
    {
        public static DataTable RetrieveCategories( )
        {
            return DAL.GetData("getJokeCategories");
        }

        public static DataTable GetJokesByCategory(int categoryId)
        {
            List<parameters> parms = new List<parameters>();
            parms.Add(new parameters("@categoryId", categoryId, SqlDbType.Int, ParameterDirection.Input));
            return DAL.GetData("getJokesByCategory", parms);
        }
    }
}
