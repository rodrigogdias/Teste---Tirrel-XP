using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTirrelXPBL.Entidade
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public String NomeCliente { get; set; }
        public String NomeEmpresa { get; set; }
        public String Email { get; set; }
        public String CNPJ { get; set; }
        public String TelefoneComercial { get; set; }
        public String Celular { get; set; }
        public String CEP { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }

        public static void Save(Cliente oCliente, String sConnectionString)
        {
            if (string.IsNullOrWhiteSpace(oCliente.IdCliente))
            {
                string sId = string.Empty;
                foreach (var item in oCliente.NomeCliente.Split(' '))
                {
                    sId += item.Substring(0, 3).ToLower();
                }
                bool bNewId = false;
                int nNew = 1;
                while (!bNewId)
                {
                    if (BLL.ClienteBLL.Get(sId, sConnectionString) != null)
                    {
                        sId += nNew.ToString();
                    }
                    else
                    {
                        bNewId = true;
                    }
                }
                oCliente.IdCliente = sId;
            }

            BLL.ClienteBLL.Save(oCliente, sConnectionString);
        }

        public static void Update(Cliente oCliente, String sConnectionString)
        {
            BLL.ClienteBLL.Update(oCliente, sConnectionString);
        }

        public static List<Cliente> List(string sConnectionString)
        {
            return BLL.ClienteBLL.List(sConnectionString);
        }

        public static Cliente Get(string sIdCliente, string sConnectionString)
        {
            return BLL.ClienteBLL.Get(sIdCliente, sConnectionString);
        }
    }
}
