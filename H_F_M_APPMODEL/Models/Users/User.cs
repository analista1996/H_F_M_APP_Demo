using H_F_M_APPMODEL.Models.Permitions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace H_F_M_APPMODEL.Models.Users
{
    public class User
    {
        //user id used to identify users on the database and system.
        [Key]
        public int User_Id { get; set; }
        //reference to the permitions applied to the current user loged on the system.
        [ForeignKey("Permition")]
        public int Permition_Id { get; set; }
        //user name 
        [MaxLength(15)]
        public string UserName { get; set; }
        //password initial create over an criptation sample.
        public string PassWord { get; set; }
        [MaxLength(12)]
        public string Phone { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [MaxLength(1)]
        public int Activated { get; set; }
        public Permition Permition { get; set; }
        
    }
}
