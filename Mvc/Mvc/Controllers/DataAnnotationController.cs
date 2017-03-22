using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class DataAnnotationController : Controller
    {
        // GET: DataAnnotation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TestSubmit(DataAnnotationModel model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("index", model);
        }
    }
}