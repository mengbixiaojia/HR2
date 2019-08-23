using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class major_changeController : Controller
    {
        
        public ActionResult major_change()
        {
            return View();
        }

        // POST: major_change/Create
        [HttpPost]
        public ActionResult major_change(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
