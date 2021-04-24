using H_F_M_APPMODEL.Models.Payment_Method_;
using H_F_M_APPMODEL.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace H_F_M_APPMODEL.Models.Spends_
{
    public class Spends
    {
        [Key]
        public int Spend_Id { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public string Spend_Desc { get; set; }
        //refences the payment menthod using ID
        [ForeignKey("Payment_Method")]
        public int P_M_Id { get; set; }
        public double Value { get; set; }
        public DateTime DateTime { get; set; }
        public User User { get; set; }
        public Payment_Method Payment_Method { get; set; }
    }
}
