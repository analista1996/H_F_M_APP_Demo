using H_F_M_APPMODEL.Models.Permitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace H_F_M_APP.Models.IRepository.IPermitions
{
    public interface IPermition
    {
      

        public void Delete_Permition(int Id);
        public void Update_Permition(Permition permition, int id);
        public void Create_Permition(Permition permition, int id);
    }
}
