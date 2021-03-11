using H_F_M_APPMODEL.Models.Permitions;
using H_F_M_APPMODEL.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace H_F_M_APPMODEL.Models.Permitions
{
    public class Permition
    {
        #region permition applied to the user based on his level of access.
        //permition Id
        [Key]
        public int Permition_Id { get; set; }
        //reference key from user Table
        //type of the user
        [MaxLength(1)]
        public int Permition_Type { get; set; }
        #endregion
    }
}
