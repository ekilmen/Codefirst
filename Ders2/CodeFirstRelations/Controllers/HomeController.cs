using CodeFirstRelations.Models.DB.Ctx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstRelations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            UserDBContext DB = new UserDBContext();

           var q= DB.UserList.Select(x => new
            {
               x.UserId,
               x.Email,
               x.UserPass,
               x.Name,
               x.Surname,
               x.Auth.AuthName,
               x.Msg
            });


            return View();
        }
    }
}