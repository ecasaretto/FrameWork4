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
    
        static MiPerfil()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        internal static Tuple<int,string, string, string, string, int> miPerfil(String email)
        {
            
            string firstName = "...";
            string lastName = "...";
            string lastLogin="..";
            string lastChangePassword="..";

            int res = -1;
            int isAdmin = -1 ;
           
            DbCommand comandoSQL = Database.CreateCommand("sp_mostrarPerfil");
            comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@email", System.Data.DbType.String, email));
            DataTable dt = Database.ExecuteSelectCommand(comandoSQL);
            if (dt.Rows.Count > 0)
            {
                res = (int)dt.Rows[0]["res"];
                firstName = dt.Rows[0]["firstName"].ToString();
                lastName = dt.Rows[0]["lastName"].ToString();
                lastLogin = dt.Rows[0]["lastLogin"].ToString();
                lastChangePassword = dt.Rows[0]["lastChangePassword"].ToString();

                var resultadoSql = FrameWork4.MiPerfil.esAdmin(email);
                isAdmin = resultadoSql.Item2;

                         

            }
            return Tuple.Create(res,firstName,lastName,lastLogin,lastChangePassword,isAdmin);

        }

        //////////////////////

        internal static Tuple<int, int> esAdmin(String sesion)
        {
            int res=0;
            int isAdmin; 
            DbCommand comando2 = Database.CreateCommand("Portal_User_Rol_Val");
            comando2.Parameters.Add(Database.CreateParameter(comando2, "@sessionID", System.Data.DbType.String, sesion));
            DataTable dt = Database.ExecuteSelectCommand(comando2);
            isAdmin = (int)dt.Rows[0]["isAdmin"];
            res = (int)dt.Rows[0]["res"];
            return Tuple.Create(res, isAdmin);
            }
           







    }
}
    


        

