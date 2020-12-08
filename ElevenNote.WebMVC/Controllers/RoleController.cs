using ElevenNote.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            var userService = new UserService();
            var roles = userService.GetAllRoles();
            return View(roles);
        }
    }
}