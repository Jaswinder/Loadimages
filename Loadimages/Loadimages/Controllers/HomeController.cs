using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loadimages.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public string getImage()
        {
            string html = "";
            for (int i = 0; i <= 5; i++)
            {
                html += "<img src='/usr.jpg' height='300' />";
            }
            return html;
        }
    }
}
