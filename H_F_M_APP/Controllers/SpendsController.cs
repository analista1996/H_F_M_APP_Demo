using H_F_M_APPDATA.Context;
using H_F_M_APPMODEL.Models.Payment_Method_;
using H_F_M_APPMODEL.Models.Spends_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H_F_M_APP.Controllers
{
    public class SpendsController : Controller
    {
        // GET: SpendsController
      
        private readonly HFM_Context _db;
        public SpendsController(HFM_Context db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index(string orderby,string SeachString)
        {
            
                var username_ = HttpContext.Session.GetString("Loged").ToString().Split("_");
                var User_Id = Convert.ToInt32(username_[1].Replace("_", "").ToString());
            

            

            //load the entites used on the view.
            _db.Payment_Methods.ToList();
            _db.Users.Where(c=>c.User_Id == User_Id).ToList();
            //filter and order by
            //sort by value using the hiperlink
            ViewData["SortByValue"] = string.IsNullOrEmpty(orderby) ? "value":"";
            //sort by description using the hiperlink
            ViewData["SortByDesc"] = orderby == "Spend_Desc"  ? "Spend_Desc" : "Spend_Desc";
            //sort by date using the hiperlink
            ViewData["SortByDate"] = orderby == "DateTime" ? "DateTime" : "DateTime";
            //filter using field on the view
            ViewData["CurrentFilter"] = SeachString;
            //instance of spends entites
            var spends = from s in _db.Spends where s.User_Id == User_Id select s;
            //if using search field, check if is null
            if (!String.IsNullOrEmpty(SeachString))
            {
                //if is not null retrive information relate to the filter value
                spends = spends.Where(a => a.Spend_Desc.Contains(SeachString) || a.User.UserName.Contains(SeachString));
            }
            //whaich instament to return sorted information depending on user is chouse, exemplo
            //if user click on Description Collum Head it if return informations sorted by description.
            switch (orderby)
            {
                case "value":
                    {
                        spends = spends.OrderByDescending(s => s.Value) ;
                        
                        break;
                    }
                case "Spend_Desc":
                    {
                        spends = spends.OrderByDescending(s=>s.Spend_Desc);
                        break;
                    }
                case "DateTime":
                    {
                        spends = spends.OrderByDescending(s=>s.DateTime);
                        break;
                    }
                default:
                    {
                        spends = spends.OrderBy(s=>s.Spend_Desc);
                        break;
                    }
            }
            //return the result to the view.     
            return View(await spends.ToListAsync());
        }

        // GET: SpendsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SpendsController/Create
        public ActionResult Create()
        {
            // ViewBag.P_List
              var a = _db.Payment_Methods.Select(a => new SelectListItem()
              {
                  Value = a.P_M_Id.ToString(),
                  Text = a.Name
              }).ToList();
            ViewBag.P_List = a;
            return View();
        }

        // POST: SpendsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Spends spends)
        {
            var username_ = HttpContext.Session.GetString("Loged").ToString().Split("_");
            var User_Id = Convert.ToInt32(username_[1].Replace("_", "").ToString());


            try
            {
                if (ModelState.IsValid)
                {
                    
                    spends.User_Id = User_Id;   
                    if (spends.DateTime.Hour == 0) 
                    {
                        
                    }
                    _db.Spends.Add(spends);
                    _db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else 
                {
                    return RedirectToAction(nameof(Create));
                }
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View();
            }
        }

        // GET: SpendsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SpendsController/Edit/5
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

        // GET: SpendsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SpendsController/Delete/5
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
