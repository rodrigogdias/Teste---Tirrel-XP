using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTirrelXPBL.Entidade;

namespace TesteTirrelXPBL.BLL
{
    class VendedorBLL
    {
        public static bool Login(Vendedor oVendedor, string sConnectionString)
        {
            bool bRetorno = false;

            SqlConnection conn = Util.ReturnConnection(sConnectionString);
            conn.Open();


            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "proc_login_vendedor";

            if (oVendedor == null)
            {
                return false;
            }
            command.Parameters.Add("login", System.Data.SqlDbType.VarChar);
            if (!string.IsNullOrWhiteSpace(oVendedor.Login))
            {
                command.Parameters[0].Value = oVendedor.Login;
            }
            else {
                command.Parameters[0].Value = DBNull.Value;
            }
            command.Parameters.Add("senha", System.Data.SqlDbType.VarChar);
            if (!string.IsNullOrWhiteSpace(oVendedor.Senha))
            {
                command.Parameters[1].Value = oVendedor.Senha;
            }
            else {
                command.Parameters[1].Value = DBNull.Value;
            }

            SqlDataReader sr = command.ExecuteReader();
            bRetorno = sr.HasRows;

            return bRetorno;
        }
    }
}
