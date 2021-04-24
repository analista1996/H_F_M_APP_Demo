using H_F_M_APPMODEL.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace H_F_M_APPMODEL.Models.Budget
{
   public  class BudGet
   {
        [Key]
        public int Id_BudGet { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public double Month_Budget { get; set; }
        public User User { get; set; }
    }
}
