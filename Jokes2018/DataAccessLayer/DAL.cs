using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace DataAccessLayer
{
    public sealed class DAL
    {
        private DAL() { }
        public static DataTable GetData(string SQLStatement, List<parameters> parms)
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);
            SqlCommand cmd = CreateCommandObject(SQLStatement, parms);
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            UnloadParms(cmd, parms);
            return dt;
        }

        public static DataTable GetData(string SQLStatement)
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SQLStatement;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cmd.Connection = cnn;
            cmd.CommandText = SQLStatement;
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public static int SendData(string SQLStatement, List<parameters> parms)
        {
            //SqlConnection cnn = new SqlConnection(Properties.Settings.Default.cnnString);
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);
            SqlCommand cmd = CreateCommandObject(SQLStatement, parms);
            cmd.Connection = cnn;

            using (cnn)
            {
                cnn.Open();
                int retval = cmd.ExecuteNonQuery();
                UnloadParms(cmd, parms);
                cnn.Close();
                return retval;
            }
        }

        private static SqlCommand CreateCommandObject(string procname, List<parameters> parms)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = procname;
            cmd.CommandType = CommandType.StoredProcedure;
            if ((parms != null))
            {
                foreach (parameters x in parms)
                {
                    cmd.Parameters.Add(new SqlParameter(x.name, x.type, x.size));
                    cmd.Parameters[x.name].Value = x.value;
                    cmd.Parameters[x.name].Direction = x.parmDirect;
                }
            }
            return cmd;
        }

        private static void UnloadParms(SqlCommand cmd, List<parameters> parms)
        {
            if (parms != null)
            {
                for (int i = 0; i <= parms.Count - 1; i++)
                {
                    parameters x = parms[i];
                    x.value = cmd.Parameters[i].Value;
                    parms[i] = x;
                }
            }
        }
    }
}
