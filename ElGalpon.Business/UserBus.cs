using System;
using System.Collections.Generic;
using System.Text;
using ElGalpon.Repository;

namespace ElGalpon.Business
{
    public class UserBus
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
    }
}
