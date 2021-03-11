using H_F_M_APPMODEL.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace H_F_M_APP.Models.IRepository.IUsers
{
    public interface IUser
    {
        #region Methods
        public User Login(string user, string password);

        public void LogOut(int Id);

        public void CreateUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(User user);
        #endregion
    }
}
