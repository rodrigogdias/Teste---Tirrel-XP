using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteTirrelXPBL.Entidade;
using System.Web.Http;

namespace TesteTirrelXP.controllers
{
    public class VendedorController : ApiController
    {
        [HttpGet(), ActionName("Login")]
        [AllowAnonymous]
        public bool Login(string sLogin, string sSenha)
        {
            string sConnectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
            Vendedor oVendedor = new Vendedor { Login = sLogin, Senha = sSenha };
            return Vendedor.LoginVendedor(oVendedor, sConnectionString);
        }
    }
}