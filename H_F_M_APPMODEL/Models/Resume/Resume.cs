using H_F_M_APPMODEL.Models.Payment_Method_;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace H_F_M_APPMODEL.Models.Resume
{
    public class Resume
    {
        public int User_Id { get; set; }
        public double Total_saved { get; set; }
        public double Total_spend { get; set; }
        
        public double I_Budget { get; set; }
     
        public double F_Budget { get; set; }
        public int Purchaser_Time { get; set; }
        //Used to list payments methods most used by the user
        public List<string> P_M_Used { get; set; }
        public DateTime Start_period { get; set; }
        public DateTime End_period { get; set; }
        /*  public Resume() {
            P_M_Used = new string[1];
            P_M_Used[0] = "Empty";
        }*/
    }
    
}
