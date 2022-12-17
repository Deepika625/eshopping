using Eshopping_MVC.Repoistory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Eshopping_MVC.Models;
namespace Eshopping_MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public async Task<ActionResult> Index()
        {





            // GET: User
            List<UserModel> users = new List<UserModel>();
            var service = new ServiceRepository();
            {
                using (var response = service.GetResponse("Users"))
                {
                    string apiResponse
                        = await response.Content.ReadAsStringAsync();
                    users = JsonConvert.DeserializeObject
<List<UserModel>>(apiResponse);
                }
            }
            return View(users);
        }
         public async Task<ActionResult> Create(UserModel userViewModel)
         {
             if (ModelState.IsValid)
             {
                 UserModel newUser = new UserModel();
                 var service = new ServiceRepository();
                 {
                     using (var response = service.PostResponse("users", userViewModel))
                     {
                         string apiResponse = await response.Content.ReadAsStringAsync();
                         newUser = JsonConvert.DeserializeObject<UserModel>(apiResponse);
                     }
                 }

 

 

 

                return RedirectToAction("Index");
             }
             return View(userViewModel);
         }
    }
}
    