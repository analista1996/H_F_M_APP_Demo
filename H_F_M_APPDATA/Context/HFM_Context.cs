using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace H_F_M_APPDATA.Context
{
    public class HFM_Context: DbContext
    {
        //app dbcontext
        public HFM_Context(DbContextOptions options) : base(options) 
        {
        
        }
    }
}
