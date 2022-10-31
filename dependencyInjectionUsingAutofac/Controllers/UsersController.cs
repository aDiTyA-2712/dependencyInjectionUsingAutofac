using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using dependencyInjectionUsingAutofac.Models;

namespace dependencyInjectionUsingAutofac.Controllers
{
    public class UsersController : Controller
    {
        private dependencyInjectionUsingAutofacContext _db ;

        public UsersController(dependencyInjectionUsingAutofacContext db)
        {
            _db = db;
        }

        // GET: Users
        public ActionResult Index()
        {
            return View(_db.Users.ToList());
        }

        
    }
}
