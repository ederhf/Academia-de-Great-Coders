using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize]
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/

        [Log]
        public ActionResult Search(string name="valor default")
        {
            throw new Exception("Ahhhhhhhhh!");

            var message = Server.HtmlEncode(name);

            return Content(message);

            //return Json(new { Message = message, Name = "Éder", }, JsonRequestBehavior.AllowGet);

            //return File(Server.MapPath("~/Content/site.css"), "text/css");

            //return Content(message);
        }

       
    }
}
