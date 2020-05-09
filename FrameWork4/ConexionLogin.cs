using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Text.RegularExpressions;

namespace FrameWork4
{
    public class ConexionLogin 
    {
        
        static ConexionLogin()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        internal static String muestraValor()
        {
            string res = " ";
            int parametro1 = 6;
            DbCommand comm = Database.CreateCommand("sp_muestraValor");
            comm.Parameters.Add(Database.CreateParameter(comm, "@parametro1", DbType.Int32,parametro1));
            DataTable dt = Database.ExecuteSelectCommand(comm);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                res = dt.Rows[i].ItemArray[0].ToString();
                
            }

            return res;

        }
        internal static int muestraValorRol()
        {

            return 1;

        }

        internal static Tuple<int, string> validarLogin(string usuario, string password)
        {
            int res = 0;
            string sessID="";
            DbCommand comm = Database.CreateCommand("Portal_User_Password_Val");
            comm.Parameters.Add(Database.CreateParameter(comm, "@email", DbType.String, usuario));
            comm.Parameters.Add(Database.CreateParameter(comm, "@password", DbType.String, password));
            DataTable dt = Database.ExecuteSelectCommand(comm);
            if (dt.Rows.Count > 0)
            {
                res = (int)dt.Rows[0]["res"];
                sessID =dt.Rows[0]["sessionID"].ToString();
            }
            return Tuple.Create(res, sessID);
             
        }




    }
}
