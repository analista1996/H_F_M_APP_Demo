using H_F_M_APP.Models.IReporsitory.IResume;
using H_F_M_APP.Models.IRepository.IUsers;
using H_F_M_APPDATA.Context;
using H_F_M_APPMODEL.Models.Resume;
using H_F_M_APPMODEL.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace H_F_M_APP.Controllers
{
    
    public class UserController : Controller
    {
        private readonly HFM_Context _db;
        public UserController(HFM_Context db)
        {
            _db = db;
         
        }

        // GET: UserController
       [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
              return View();
        }

       
        [HttpPost]
        public  ActionResult Login(IFormCollection colle)
        {

            //and passing de db context to be used there.
            
            var UserLogin = new UserRepository(_db);
            var User = UserLogin.Login(colle["username"], colle["password"]);
            //sample step check to see if the user is an adm or not, be an adm unlock the whole menu
            if (User.Permition_Id > 0)
            {
                //passing values about the user to the session
                string data = $"{User.UserName}_" +
                 $"{User.User_Id.ToString()}_" +
                 $"{User.Permition.Permition_Type.ToString()}_";
                //setting the session name and value
                HttpContext.Session.SetString("Loged",data);
                /*instance of resumerepository where contains methods which one bring all informations
                about an specific user*/
                var resume = new ResumeRepository(_db);
                //sending resume informations to the view by viewdata 
                ViewData["resume"] = resume.GetResume(HttpContext);
                //returning view 

                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                TempData["erro"] = "fail";
                return View("~/Views/User/Index.cshtml");
            }
        }
        public IActionResult LogOut() 
        {
            HttpContext.Session.Remove("Loged");
            return RedirectToAction("Index");
        }
        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
               Console.WriteLine( collection["Spend_Desc"]);
                return View("~/Views/Home/Index.cshtml");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
