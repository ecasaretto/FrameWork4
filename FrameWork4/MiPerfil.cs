using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace FrameWork4
{
    public partial class MiPerfil
    {
        private String nombre = "";
        private String apellido = "";
        private String ultimoIngreso = "";
        private String ultimoCambioPass = "";
        private String esAdmin = "";
        static MiPerfil()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        internal static Tuple<int,string, string, string, string, int> miPerfil(String email)
        {
            int res = -1;
            string firstName = "...";
            string lastName = "...";
            string lastLogin="..";
            string lastChangePassword="..";
            int isAdmin = -1;

            DbCommand comandoSQL = Database.CreateCommand("sp_mostrarPerfil");
            comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@email", System.Data.DbType.String, email));
            DataTable dt = Database.ExecuteSelectCommand(comandoSQL);

            if (dt.Rows.Count > 0)
            {
                res = (int)dt.Rows[0]["res"];
                firstName = dt.Rows[0]["firstName"].ToString();
                lastLogin = dt.Rows[0]["lastLogin"].ToString();
                lastChangePassword = dt.Rows[0]["lastChangePassword"].ToString();
                isAdmin = 0;
            }
            return Tuple.Create(res,firstName,lastName,lastLogin,lastChangePassword,isAdmin);

        }

        
            







    }
}
    


        

