using H_F_M_APPMODEL.Models.Permitions;
using H_F_M_APPMODEL.Models.Users;
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
        public DbSet<User> Users { get; set; }
        public DbSet<Permition> Permitions { get; set; }
    }
}
