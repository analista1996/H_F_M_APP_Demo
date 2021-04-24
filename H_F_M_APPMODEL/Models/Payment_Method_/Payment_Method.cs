using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Web.Mvc;

namespace H_F_M_APPMODEL.Models.Payment_Method_
{
  public  class Payment_Method
    {
        [Key]
        public int P_M_Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public List<SelectListItem> Payment_Methods { get; set; }
    }
}
