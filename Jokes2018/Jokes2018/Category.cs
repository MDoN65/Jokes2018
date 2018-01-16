using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Jokes2018
{
    public class Category : ICategory
    {
        internal Category() { }
        internal int _categoryId;
        internal string _categoryName;
        internal string _description;
        internal DateTime _createdDate;

        public int CategoryId
        {
            get
            {
                return _categoryId;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Category Id must greater than 0");
                }
                if (value == _categoryId)
                {
                    return;
                }

                this._categoryId = value;
            }
        }
        public string CategoryName
        {

            get
            {
                return this._categoryName;

            }
            set
            {
                if (value == _categoryName)
                {
                    return;
                }
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Category Name cannot be null or empty");
                }
                this._categoryName = value;
            }
        }
        public string Description
        {
            get
            {
                return this._description;

            }
            set
            {
                if (value == _description)
                {
                    return;
                }
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Description cannot be null or empty");
                }
                this._description = value;

            }

        }
        public DateTime CreatedDate
        {
            get
            {

                return this._createdDate;

            }
            set
            {
                if (value == new DateTime())
                {
                    throw new ArgumentNullException("Start Date cannot be null or empty");
                }

                if (value == _createdDate)
                {
                    return;
                }

                this._createdDate = value;
            }
        }
    }
}
