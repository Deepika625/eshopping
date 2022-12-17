using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using Eshopping_webapi.Repoistory;
using Microsoft.Azure.Documents;
using System.Web.Http;
using Eshopping_webapi.Models;

namespace Eshopping_webapi.Controllers
{
   


namespace ShoppingSystemAPI.Controllers
    {
        [RoutePrefix("api/Login")]
        public class LoginController : ApiController
        {
            LoginRepo _Loginrepo;
            public LoginController()
            {
                this._Loginrepo = new LoginRepo(new shoppingzoneEntities());
            }

            [HttpPost]
            [Route("")]
            public IHttpActionResult VerifyLogin(Loginuser objlogin)
            {
                User user = null;
                try
                {
                    user = _Loginrepo.VerifyLogin(objlogin.EmailID, objlogin.Password);

                    if (user != null)
                    {
                        //return NotFound();
                        return Ok(user);

                    }

                }
                catch (Exception ex)
                {

                }

                //return Ok(customer);
                return NotFound();

            }
        }
    }
}





