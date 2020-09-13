using System;
using System.Collections.Generic;
using System.Text;
using ElGalpon.Models;
using ElGalpon.Repository;

namespace ElGalpon.Business
{
    public class UserBus
    {
        UserRepository userRepository = new UserRepository();
        public bool LoginUser(string user, string pass)
        {
            return userRepository.Login(user, pass);
        }

        public ResultModel<UserModel> Login(string user, string pass)
        {
            var response = new ResultModel<UserModel>();
            try
            {
                var result = userRepository.LoginUser(user, pass);
                if (result != null)
                    response.Return = result;
                else
                {
                    response.AddErrorMessage("El usuario o la contraseña son incorrectos.");
                }
            }
            catch (Exception ex)
            {
                response.AddErrorMessage(ex.ToString());
            }

            return response;
        }

        public ResultModel<UserModel> ChangeUserPassword(string user, string pass)
        {
            var response = new ResultModel<UserModel>();
            try
            {
                userRepository.ChangeUserPassword(user, pass);
                //var result = userRepository.ChangeUserPassword(user, pass);
                //if (result != null)
                //    response.Return = result;
                //else
                //{
                //    response.AddErrorMessage("El usuario o la contraseña son incorrectos.");
                //}
            }
            catch (Exception ex)
            {
                response.AddErrorMessage(ex.ToString());
            }

            return response;
        }
    }
}
