using AbmNetCore5.Data;
using AbmNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AbmNetCore5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AplicationDbContext _context;

        public HomeController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var db = new Models.DB.TestCrudContext();
            IEnumerable<Models.DB.TUser> lst = db.TUsers;

            return View(lst);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.DB.TUser oUser)
        {
            if (ModelState.IsValid)
            {                                
                var db = new Models.DB.TestCrudContext();
                db.TUsers.Add(oUser);
                db.SaveChanges();

                TempData["msje"] = "Registro agregado correctamente.";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        public IActionResult Update(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var db = new Models.DB.TestCrudContext();
            var oInstancia =  db.TUsers.Find(id);

            if (oInstancia == null)
            {
                return NotFound();
            }

            return View(oInstancia);
        }

        [HttpPost]
        public IActionResult Update(Models.DB.TUser oUser)
        {
            var db = new Models.DB.TestCrudContext();
            if (ModelState.IsValid)
            {
                db.TUsers.Update(oUser);
                db.SaveChanges();

                TempData["msje"] = "Registro actualizado correctamente.";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var db = new Models.DB.TestCrudContext();
            var oUsr = db.TUsers.Find(id);

            if (oUsr == null)
            {
                TempData["msje"] = "No se puede encontrar el usuario que quiere eliminar.";
                return RedirectToAction("Index", "Home");
            }

            return View(oUsr);
        }

        [HttpPost]
        public IActionResult DeleteUsuario(int CodUsuario)
        {
            if (CodUsuario == 0)
            {
                TempData["msje"] = "No se puede encontrar el usuario que quiere eliminar.";
                return RedirectToAction("Index", "Home");
            }
            var db = new Models.DB.TestCrudContext();
            var oUsr = db.TUsers.Find(CodUsuario);
            

            if (oUsr == null)
            {
                TempData["msje"] = "No se puede encontrar el usuario que quiere eliminar.";
                return RedirectToAction("Index", "Home");
            }

            db.TUsers.Remove(oUsr);
            db.SaveChanges();

            TempData["msje"] = "Registro Eliminado correctamente.";
            return RedirectToAction("Index", "Home");

        }


        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string usr, string pwd)
        {

            try
            {
                if (!string.IsNullOrEmpty(usr) && !string.IsNullOrEmpty(pwd))
                {
                    using (var db = new Models.DB.TestCrudContext())
                    {
                        var lst = from u in db.TUsers
                                  where u.TxtUser == usr.Trim() && u.TxtPassword == pwd.Trim()
                                  select u;

                        if (lst.Count() > 0)
                        {
                           Models.DB.TUser oUsuario = lst.FirstOrDefault();
                            return RedirectToAction("index", "Home");
                        }
                        else
                        {
                            return RedirectToAction("index", "Home", new { message=" Datos Incorrectos"});
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
