using H_F_M_APPDATA.Context;
using H_F_M_APPMODEL.Models.Permitions;
using System;
using System.Collections.Generic;
using System.Text;

namespace H_F_M_APP.Models.IRepository.IPermitions
{
    public class PermitionsRepository: IPermition
    {
        public readonly HFM_Context _db;
        public PermitionsRepository(HFM_Context db) 
        {
            _db =db;
        }
        #region methods 
        public void Update_Permition(Permition permition,int id) 
        {
            try
            {

            }
            catch (Exception ex) 
            {

                //print exception on console
                Console.WriteLine(ex.Message);
            }
        }
        public void Delete_Permition(int Id) 
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                //print exception on console
                Console.WriteLine(ex.Message);
            }
        }
        public void Create_Permition(Permition permition,int id) 
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                //print exception on console
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
