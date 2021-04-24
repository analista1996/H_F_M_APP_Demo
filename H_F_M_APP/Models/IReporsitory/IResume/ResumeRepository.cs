using H_F_M_APPDATA.Context;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using H_F_M_APPMODEL.Models.Resume;
using Microsoft.AspNetCore.Http;

namespace H_F_M_APP.Models.IReporsitory.IResume
{
    public class ResumeRepository: IResume_
    {
        private readonly HFM_Context _db;

        public ResumeRepository(HFM_Context db)
        {
            _db = db;
        }
        public Resume GetResume(HttpContext httpContext)
        {
            try
            {
                
                var username_ = httpContext.Session.GetString("Loged").ToString().Split("_");
                var UserId = Convert.ToInt32(username_[1].Replace("_", "").ToString());
                var Resume = new Resume
                {
                    Purchaser_Time = _db.Spends.Where(c => c.User_Id == UserId).Count(),
                    User_Id = _db.Users.Where(c => c.User_Id == UserId).FirstOrDefault().User_Id,
                    P_M_Used = _db.Spends.Where(c => c.Payment_Method.P_M_Id == c.P_M_Id && c.User_Id == UserId).Select(c => c.Payment_Method.Name).Distinct().ToList(),
                    Total_spend = double.Parse(_db.Spends.Where(c => c.User_Id == UserId).Sum(c => c.Value).ToString()),
                    I_Budget = double.Parse(_db.BudGets.Where(c => c.User_Id == UserId).Sum(c => c.Month_Budget).ToString()),
                    F_Budget = (double.Parse(_db.BudGets.Where(c => c.User_Id == UserId).Sum(c => c.Month_Budget).ToString()) - 
                    double.Parse(_db.Spends.Where(c => c.User_Id == UserId).Sum(c => c.Value).ToString())),
                    Total_saved = (_db.Saves.Where(c => c.User_Id == UserId).Sum(c => c.Save_value) +
                    (_db.BudGets.Where(c => c.User_Id == UserId).Sum(c => c.Month_Budget) -
                    _db.Spends.Where(c => c.User_Id == UserId).Sum(c => c.Value)))
                };
                return Resume;
            }
            catch (Exception ex)
            {
                
                //print exception on console
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
