using Eshopping_webapi.Models;
using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eshopping_webapi.Repoistory
{





    public class LoginRepo : Ilogin
    {
        shoppingzoneEntities _LoginEntities = null;
        public User VerifyLogin(string EmailID, string Password)
        {
            User user = null;
            try
            {
                var checkValidUser = _LoginEntities.User.Where(m => m.EmailID == EmailID && m.Password == Password).FirstOrDefault();
                if (checkValidUser != null)
                {
                    user = checkValidUser;
                }

                else
                {
                    user = null;
                }
            }
            catch (Exception ex)
            {
            }
            return user;
        }

        public LoginRepo(shoppingzoneEntities loginentities)
        {
            this._LoginEntities = loginentities;
        }

    }
}


   