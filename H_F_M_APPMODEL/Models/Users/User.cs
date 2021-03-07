using System;
using System.Collections.Generic;
using System.Text;

namespace H_F_M_APPMODEL.Models.Users
{
    public class User
    {
        public int User_Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        private void Login() 
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Number: {ex.Message},  Target: {ex.TargetSite}");
            }
            finally 
            { }
        }
    }
}
