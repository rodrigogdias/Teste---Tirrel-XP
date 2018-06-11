using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace TesteTirrelXP
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapHttpRoute("ListCliente",
                                           "Cliente/List",
                                           new { Controller = "Cliente", Action = "List" });

            RouteTable.Routes.MapHttpRoute("SaveCliente",
                                           "Cliente/Save",
                                           new { Controller = "Cliente", Action = "Save" });

            RouteTable.Routes.MapHttpRoute("UpdateCliente",
                                           "Cliente/Update",
                                           new { Controller = "Cliente", Action = "Update" });

            RouteTable.Routes.MapHttpRoute("GetCliente",
                                           "Cliente/Get/{sIdCliente}",
                                           new { Controller = "Cliente", Action = "Get" });

            RouteTable.Routes.MapHttpRoute("LoginVendedor",
                                           "Vendedor/Login/{sLogin}/{sSenha}",
                                           new { Controller = "Vendedor", Action = "Login" });
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}