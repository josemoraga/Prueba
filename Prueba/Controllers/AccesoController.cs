using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string User, string Pass)
        {
            try
            {
                using (Models.LoginDemoEntities db = new Models.LoginDemoEntities()) //Creacion de objeto para poder obtener datos de nuestra DB
                {
                    //Uso de linq para hacer la consulta y seleccionar los datos para conexion
                    var dUser = (from dat in db.Users
                                                where dat.Email == User && dat.Password == Pass
                                                select dat).FirstOrDefault();

                    if (dUser == null)
                    {
                        return View();
                    }
                    Session["User"] = dUser;
                }

                    return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}