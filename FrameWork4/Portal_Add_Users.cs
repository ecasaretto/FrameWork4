using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace FrameWork4
{
    public class Portal_Add_User

    {
        static Portal_Add_User()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        internal static int PortalAddUser(string email, string firstName, string lastName, string password, bool isAdmin, bool isEnable)
        {
            
            int resultadoSQL = -1;
            DbCommand comandoSQL = Database.CreateCommand("Portal_Add_Users");
            comandoSQL.Parameters.Add(Database.CreateParameter(comandoSQL, "@fisrtName", System.Data.DbType.String, firstName));
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

        internal static object PortalAddUser()
        {
            throw new NotImplementedException();
        }


        /*
         internal static Tuple<int, string> altaEmpleado(string nombre, string Apellido, string EmpleadoCategoriaDescripcion,
              string EmpleadoEstadoDescripcion, DateTime FechaAlta, DateTime FechaNacimiento, string CorreoElectronico,
              string telefono, string NroCUIL, string Domicilio)
        {
            int res = 0;
            string sessID = "";
            DbCommand comm = Database.CreateCommand("sp_AltaEmpleado");
            comm.Parameters.Add(Database.CreateParameter(comm, "@Nombre", DbType.String, nombre));
            comm.Parameters.Add(Database.CreateParameter(comm, "@Apellido", DbType.String, Apellido));
            comm.Parameters.Add(Database.CreateParameter(comm, "@EmpleadoCategoriaDescripcion", DbType.String, EmpleadoCategoriaDescripcion));
            comm.Parameters.Add(Database.CreateParameter(comm, "@EmpleadoEstadoDescripcion", DbType.String, EmpleadoEstadoDescripcion));
            comm.Parameters.Add(Database.CreateParameter(comm, "@FechaAlta", DbType.Date, FechaAlta));

            comm.Parameters.Add(Database.CreateParameter(comm, "@FechaNacimiento", DbType.Date, FechaNacimiento));
            comm.Parameters.Add(Database.CreateParameter(comm, "@CorreoElectronico", DbType.String, CorreoElectronico));
            comm.Parameters.Add(Database.CreateParameter(comm, "@Telefono", DbType.String, telefono));

            comm.Parameters.Add(Database.CreateParameter(comm, "@NroCUIL", DbType.String, NroCUIL));
            comm.Parameters.Add(Database.CreateParameter(comm, "@Domicilio", DbType.String, Domicilio));

            DataTable dt = Database.ExecuteSelectCommand(comm);
            if (dt.Rows.Count > 0)
            {
                res = (int)dt.Rows[0]["res"];
                sessID = dt.Rows[0]["sessionID"].ToString();

            }
            return Tuple.Create(res, sessID);

        }

         */
    }




}