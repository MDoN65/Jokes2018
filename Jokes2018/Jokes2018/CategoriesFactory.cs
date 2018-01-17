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

            List<CategoryLookup> lstContact = Repackage(dt);
            return lstContact;
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
                throw new ArgumentException("No contacts are on file");
            }

        }
    }
}
