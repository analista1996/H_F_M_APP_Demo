using H_F_M_APPDATA.Context;
using H_F_M_APPMODEL.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H_F_M_APP.Models.IRepository.IUsers
{
   public class UserRepository:IUser
    {
        //login method which one will connect to the database and allow the user to have access to the system
        //based on his permitions.
        private readonly HFM_Context _db;
        
        public UserRepository(HFM_Context db) 
        {
            _db = db;
        }
        public User Login(string user,string password)
        {
            try
            {
                var user_ = _db.Users.Where(a => a.PassWord.Equals(password) && a.UserName.Equals(user)).First();
                if (user_.User_Id != 0) 
                {
                    user_.Permition = _db.Permitions.Where(a => a.Permition_Id.Equals(user_.Permition_Id)).First();
                }      
                return user_;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Number: {ex.Message},  Target: {ex.TargetSite}");
                return new User() { User_Id =0}; 
            }

        }
        //logout from the system and then return to the login page
        public void LogOut(int id) 
        {
            try
            {
             
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Number: {ex.Message},  Target: {ex.TargetSite}");
             
            }
        }
        //create new user
        public void CreateUser(User user)
        {
            try
            {


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Number: {ex.Message},  Target: {ex.TargetSite}");

            }
        }
        //update user informations
        public void UpdateUser(User user)
        {
            try
            {


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Number: {ex.Message},  Target: {ex.TargetSite}");

            }
        }
        //delete user if there`s no related information on reports or things like that
        public void DeleteUser(User user)
        {
            try
            {


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Number: {ex.Message},  Target: {ex.TargetSite}");

            }
        }
    }
}
