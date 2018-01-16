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

        public static List<Category> Create()
        {
            DataTable dt = ContactSQL.RetrieveAll();

            List<ContactLookup> lstContact = Repackage(dt);
            return lstContact;
        }

        private static List<ContactLookup> Repackage(DataTable dt)
        {
            List<ContactLookup> list = new List<ContactLookup>();

            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ContactLookup myContactLookup = new ContactLookup();

                    myContactLookup.Name = dr["Name"].ToString();
                    myContactLookup.ContactId = Convert.ToInt32(dr["ContactId"]);
                    myContactLookup.Email = dr["Email"].ToString();
                    list.Add(myContactLookup);
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
