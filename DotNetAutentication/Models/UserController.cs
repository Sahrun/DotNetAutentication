using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetAutentication.Models
{
  
        [CustomAuthorize(Roles = "User")]
        public class UserController : Controller
        {
            public ActionResult Index() {
                return View();
            }
        }
}