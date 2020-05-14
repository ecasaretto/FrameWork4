using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrameWork4
{


    internal static int MiPerfil(string email, string firstName, string lastName, string password, bool isAdmin, bool isEnable)
    {

        int resultadoSQL = -1;
        DbCommand comandoSQL = Database.CreateCommand("Portal_Add_Users");
        comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@email", System.Data.DbType.String, email));
        comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@firstName", System.Data.DbType.String, firstName));
        comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@lastName", System.Data.DbType.String, lastName));
        comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@password", System.Data.DbType.String, password));
        comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@isAdmin", System.Data.DbType.String, isAdmin));
        comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@enable", System.Data.DbType.String, isEnable));

        DataTable dt = Database.ExecuteSelectCommand(comandoSQL);
        if (dt.Rows.Count > 0)
        {
            resultadoSQL = (int)dt.Rows[0]["res"];


        }
        return resultadoSQL;


    }

}