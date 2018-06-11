using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteTirrelXPBL.Entidade;
using System.Web.Http;

namespace TesteTirrelXP.controllers
{
    public class ClienteController : ApiController
    {
        [HttpGet(), ActionName("Get")]
        [AllowAnonymous]
        public Cliente GetCliente(string sIdCliente)
        {
            string sConnectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
            return Cliente.Get(sIdCliente,sConnectionString);
        }

        [HttpPost(), ActionName("Save")]
        [AllowAnonymous]
        public Cliente SaveCliente(Cliente oCliente)
        {
            string sConnectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
            Cliente.Save(oCliente,   sConnectionString);
            return oCliente;
        }

        [HttpPost(), ActionName("Update")]
        [AllowAnonymous]
        public Cliente UpdateCliente(Cliente oCliente)
        {
            string sConnectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
            Cliente.Update(oCliente, sConnectionString);
            return oCliente;
        }


        [HttpGet(), ActionName("List")]
        [AllowAnonymous]
        public List<Cliente> ListCliente()
        {
            string sConnectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
            return Cliente.List(sConnectionString);
        }
    }
}