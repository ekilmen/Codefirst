using CodefirstIlkDers.Models.DB.Ctx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodefirstIlkDers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            UserDBContext DB = new UserDBContext();

            DB.UserList.Add(new Models.DB.Mdl.User
            {
                Name="Erkan",
                Surname="Kilmen",
                Email="ekilmen@erkankilmen.com",
                UserPass="1",
                IsDelete=false
            });

            DB.SaveChanges();

            return View();
        }
    }
}