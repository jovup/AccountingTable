using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingTable.Controllers
{
    public class ValidateController : Controller
    {
        public ActionResult Amount( int amount )
        {
            var isValid = amount >= 1 && amount <= int.MaxValue;
            return Json( isValid, JsonRequestBehavior.AllowGet );
        }

        public ActionResult Date( DateTime date )
        {
            var isValid = date <= DateTime.Now;
            return Json( isValid, JsonRequestBehavior.AllowGet );
        }
    }
}