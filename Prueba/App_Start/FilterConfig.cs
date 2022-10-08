using Prueba.Filters;
using System.Web;
using System.Web.Mvc;

namespace Prueba
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filters.ValidarCredenciales()); //Damos de alta o usamos ya el filtro creado, verificar Sesion
        }
    }
}
