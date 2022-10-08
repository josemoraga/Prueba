using Prueba.Controllers;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Filters
{
    public class ValidarCredenciales : ActionFilterAttribute
    {
        private Users dUsuario;

        public override void OnActionExecuting(ActionExecutingContext filterContext) //Creando la sobrecarga al metodo por la herencia
        {
            base.OnActionExecuting(filterContext);

            dUsuario = (Users)HttpContext.Current.Session["User"];
            if (dUsuario == null)
            {
                if (filterContext.Controller is AccesoController == false)
                {
                    filterContext.HttpContext.Response.Redirect("/Acceso/Login");
                }
            }
        }
    }
}