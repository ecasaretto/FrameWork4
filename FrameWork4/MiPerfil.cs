using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
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

        internal static int LmiPerfil(String email)
        {

            int resultadoSQL = -1;
            DbCommand comandoSQL = Database.CreateCommand("sp_DatosPerfilUsuario");
            comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@email", System.Data.DbType.String, email));


            DataTable dt = Database.ExecuteSelectCommand(comandoSQL);
            if (dt.Rows.Count > 0)
            {
                resultadoSQL = (int)dt.Rows[0]["res"];


            }
            return resultadoSQL;


        }
    }
}
    


        

