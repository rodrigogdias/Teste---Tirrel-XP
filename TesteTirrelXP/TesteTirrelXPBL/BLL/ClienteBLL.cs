using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteTirrelXPBL.Entidade;

namespace TesteTirrelXPBL.BLL
{
    class ClienteBLL
    {
        public static void Save(Cliente oCliente, String sConnectionString)
        {
            SqlConnection conn = Util.ReturnConnection(sConnectionString);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "proc_save_cliente";

            command.Parameters.Add("id_cliente", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = oCliente.IdCliente;
            command.Parameters.Add("nome_cliente", System.Data.SqlDbType.VarChar);
            command.Parameters[1].Value = oCliente.NomeCliente;
            command.Parameters.Add("nome_empresa", System.Data.SqlDbType.VarChar);
            command.Parameters[2].Value = oCliente.NomeEmpresa;
            command.Parameters.Add("email", System.Data.SqlDbType.VarChar);
            command.Parameters[3].Value = oCliente.Email;
            command.Parameters.Add("cnpj", System.Data.SqlDbType.VarChar);
            command.Parameters[4].Value = oCliente.CNPJ;
            command.Parameters.Add("telefone_comercial", System.Data.SqlDbType.VarChar);
            command.Parameters[5].Value = oCliente.TelefoneComercial;
            command.Parameters.Add("celular", System.Data.SqlDbType.VarChar);
            command.Parameters[6].Value = oCliente.Celular;
            command.Parameters.Add("cep", System.Data.SqlDbType.VarChar);
            command.Parameters[7].Value = oCliente.CEP;
            command.Parameters.Add("cidade", System.Data.SqlDbType.VarChar);
            command.Parameters[8].Value = oCliente.Cidade;
            command.Parameters.Add("estado", System.Data.SqlDbType.VarChar);
            command.Parameters[9].Value = oCliente.Estado;

            command.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
            conn.Dispose();
        }

        public static void Update(Cliente oCliente, String sConnectionString)
        {
            SqlConnection conn = Util.ReturnConnection(sConnectionString);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "proc_update_cliente";

            command.Parameters.Add("id_cliente", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = oCliente.IdCliente;
            command.Parameters.Add("nome_cliente", System.Data.SqlDbType.VarChar);
            command.Parameters[1].Value = oCliente.NomeCliente;
            command.Parameters.Add("nome_empresa", System.Data.SqlDbType.VarChar);
            command.Parameters[2].Value = oCliente.NomeEmpresa;
            command.Parameters.Add("email", System.Data.SqlDbType.VarChar);
            command.Parameters[3].Value = oCliente.Email;
            command.Parameters.Add("cnpj", System.Data.SqlDbType.VarChar);
            command.Parameters[4].Value = oCliente.CNPJ;
            command.Parameters.Add("telefone_comercial", System.Data.SqlDbType.VarChar);
            command.Parameters[5].Value = oCliente.TelefoneComercial;
            command.Parameters.Add("celular", System.Data.SqlDbType.VarChar);
            command.Parameters[6].Value = oCliente.Celular;
            command.Parameters.Add("cep", System.Data.SqlDbType.VarChar);
            command.Parameters[7].Value = oCliente.CEP;
            command.Parameters.Add("cidade", System.Data.SqlDbType.VarChar);
            command.Parameters[8].Value = oCliente.Cidade;
            command.Parameters.Add("estado", System.Data.SqlDbType.VarChar);
            command.Parameters[9].Value = oCliente.Estado;

            command.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
            conn.Dispose();
        }

        public static List<Cliente> List(string sConnectionString)
        {
            SqlConnection conn = Util.ReturnConnection(sConnectionString);
            conn.Open();


            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "proc_list_cliente";

            //SqlDataReader sr = command.ExecuteReader();
            List<Cliente> lstCliente = new List<Cliente>();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            //da.Fill(ds);
            da.Fill(ds);

            foreach (DataRow drw in ds.Tables[0].Rows)
            {
                lstCliente.Add(new Cliente()
                {
                    IdCliente = drw["id_cliente"].ToString(),
                    NomeCliente = drw["nome_cliente"].ToString(),
                    NomeEmpresa = drw["nome_empresa"].ToString(),
                    Email = drw["email"].ToString(),
                    CNPJ = drw["cnpj"].ToString(),
                    TelefoneComercial = drw["telefone_comercial"].ToString(),
                    Celular = drw["celular"].ToString(),
                    CEP = drw["cep"].ToString(),
                    Cidade = drw["cidade"].ToString(),
                    Estado = drw["estado"].ToString()
                });
            }

            return lstCliente;
        }

        public static Cliente Get(string sIdCliente, string sConnectionString)
        {
            SqlConnection conn = Util.ReturnConnection(sConnectionString);
            conn.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "proc_return_cliente";

            command.Parameters.Add("id_cliente", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = sIdCliente;

            Cliente oCliente = null;

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow drw in ds.Tables[0].Rows)
            {
                oCliente = new Cliente()
                {
                    IdCliente = drw["id_cliente"].ToString(),
                    NomeCliente = drw["nome_cliente"].ToString(),
                    NomeEmpresa = drw["nome_empresa"].ToString(),
                    Email = drw["email"].ToString(),
                    CNPJ = drw["cnpj"].ToString(),
                    TelefoneComercial = drw["telefone_comercial"].ToString(),
                    Celular = drw["celular"].ToString(),
                    CEP = drw["cep"].ToString(),
                    Cidade = drw["cidade"].ToString(),
                    Estado = drw["estado"].ToString()
                };
            }

            return oCliente;
        }
    }


}
