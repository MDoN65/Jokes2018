using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IJokes
    {
        int Id { get; set; }
        string Title { get; set; }
        string Teaser { get; set; }
        string JokeText { get; set; }
        DateTime CreateAt { get; set; }
        int UserId { get; set; }
        int CategoryId { get; set; }
        bool IsFeatured { get; set; }

    }

    public interface ICategory
    {
        int CategoryId { get; set; }
        string CategoryName { get; set; }
        string Description { get; set; }
        DateTime CreatedDate { get; set; }
    }

    public struct parameters
    {
        public string name;
        public object value;
        public SqlDbType type;
        public ParameterDirection parmDirect;
        public short size;

        public parameters(string name, object value, SqlDbType type, ParameterDirection parmDirect, short size = 0)
        {
            this.name = name;
            this.value = value;
            this.type = type;
            this.parmDirect = parmDirect;
            this.size = size;
        }
    }
}
