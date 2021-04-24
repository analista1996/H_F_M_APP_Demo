using H_F_M_APP.Models;
using H_F_M_APP.Models.IRepository.IUsers;
using H_F_M_APPDATA.Context;
using H_F_M_APPMODEL.Models.Permitions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using H_F_M_APPMODEL.Models.Resume;
using H_F_M_APP.Models.IReporsitory.IResume;

namespace H_F_M_APP.Controllers
{
    
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly HFM_Context _db;
        public HomeController(HFM_Context db)
        {
           _db= db;
        }

      
       
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Loged")))
            {
                return View("~/Views/User/Index.cshtml");
            }
            else
            {

                /*instance of resumerepository where contains methods which one bring all informations
                  about an specific user*/
                var resume = new ResumeRepository(_db);
                //sending resume informations to the view by viewdata 
                ViewData["resume"] = resume.GetResume(HttpContext);
                //returning view 
                return View();
            }
        }
    
   
   
    public IActionResult Privacy()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Loged")))
            {
                 return View("~/Views/User/Index.cshtml"); 
            }
            else
            {
                return View(); 
            }
                
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
