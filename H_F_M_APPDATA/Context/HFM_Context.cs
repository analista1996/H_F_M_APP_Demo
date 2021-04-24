using H_F_M_APPMODEL.Models.Budget;
using H_F_M_APPMODEL.Models.Payment_Method_;
using H_F_M_APPMODEL.Models.Permitions;
using H_F_M_APPMODEL.Models.Saves;
using H_F_M_APPMODEL.Models.Spends_;
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
        public DbSet<Payment_Method> Payment_Methods { get; set; }
        public DbSet<Spends> Spends { get; set; }
        public DbSet<BudGet> BudGets { get; set; }
        public DbSet<Save> Saves { get; set; }
    }
}
