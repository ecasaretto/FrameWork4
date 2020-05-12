using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameWork4
{
    public partial class Portal_Add_Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
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
}