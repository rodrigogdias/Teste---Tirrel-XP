using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTirrelXPBL.Entidade
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }

        public static bool LoginVendedor(Vendedor oVendedor, String sConnectionString)
        {
            return BLL.VendedorBLL.Login(oVendedor, sConnectionString);
        }
    }
}
