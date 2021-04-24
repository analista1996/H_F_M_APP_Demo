using H_F_M_APPMODEL.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace H_F_M_APPMODEL.Models.Saves
{
   public class Save
    {
        [Key]
        public int Save_Id { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public double Save_value { get; set; }
        public User User { get; set; }
    }
}
