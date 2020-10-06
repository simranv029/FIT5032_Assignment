using Fit5032_Assignment_Simran.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fit5032_Assignment_Simran.Controllers
{
    public class HomeController : Controller
    {
        private Entities db = new Entities();
        private Entities1 dbUser = new Entities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult PatientIndex()
        {
            var userId = User.Identity.GetUserId();
            if (userId == null)
            {
                return RedirectToAction("Index", "Home");
            }

            //var UserRoleViewModel = new UserRoleViewModel();
            //UserRoleViewModel.user = db.AspNetUsers.Find(userId);
            ////var userrole = rdb.AspNetUserRoles.First(x => x.UserId == userId);
            //var userrole = rdb.AspNetUserRoles.Where(x => x.UserId == userId).FirstOrDefault();

            //UserRoleViewModel.role = dbUser.AspNetRoles.Find(userrole.RoleId);
            //if (userId == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            ViewBag.userId = dbUser.AspNetUsers.Find(userId).UserName;
            ViewBag.roleName = dbUser.AspNetRoles.Find(db.AspNetUserRoles.Where(x => x.UserId == userId).FirstOrDefault().RoleId).Name;
            return View();
        }
    }
}