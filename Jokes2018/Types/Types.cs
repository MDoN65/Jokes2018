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
