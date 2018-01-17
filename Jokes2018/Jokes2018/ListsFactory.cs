using SqlLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes2018
{
    public static class CategoriesFactory
    {

        public static List<CategoryLookup> Create()
        {
            DataTable dt = CategorySql.RetrieveCategories();

            List<CategoryLookup> lstCats = Repackage(dt);
            return lstCats;
        }

        private static List<CategoryLookup> Repackage(DataTable dt)
        {
            List<CategoryLookup> list = new List<CategoryLookup>();

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CategoryLookup myCategory = new CategoryLookup();

                    myCategory.categoryId = Convert.ToInt32(dr["categoryID"]);
                    myCategory.categoryName = dr["categoryName"].ToString();
                    list.Add(myCategory);
                }

                return list;
            }
            else
            {
                throw new ArgumentException("No Categories are on file");
            }

        }
    }
    public static class JokesFactory
    {

        public static List<JokesLookup> Create(int catId)
        {
            DataTable dt = JokeSql.RetrieveJokesByCategory(catId);

            List<JokesLookup> lstJokes = Repackage(dt);
            return lstJokes;
        }

        private static List<JokesLookup> Repackage(DataTable dt)
        {
            List<JokesLookup> list = new List<JokesLookup>();

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    JokesLookup myJokes = new JokesLookup();

                    myJokes.jokeId = Convert.ToInt32(dr["id"]);
                    myJokes.title = dr["title"].ToString();
                    list.Add(myJokes);
                }

                return list;
            }
            else
            {
                throw new ArgumentException("No Jokes are on file");
            }

        }
    }
}
