using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokes2018
{
    public class Category : ICategory
    {
        internal Category() { }
        internal int _categoryId;
        internal string _categoryName;
        internal string _description;
        internal DateTime _createdDate;

    }
}
