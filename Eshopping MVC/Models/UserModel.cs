using Eshopping_MVC.Repoistory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Eshopping_MVC.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Net.Http;
namespace Eshopping_MVC.Models
{
    public class UserModel
    {
        public int ProfileID { get; set; }
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }





        [Required(ErrorMessage = "Gender is required")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Gender")]
        public string Gender { get; set; }









        [Display(Name = "EmailID")]
        [Required(ErrorMessage = "EmailID is required")]
        [StringLength(60)]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid EmailID")]
        public string EmailID { get; set; }






        [Display(Name = "Mobile Number")]
        [StringLength(10)]
        [Required(ErrorMessage = "Mobile Number is required")]
        [RegularExpression("[6-9][0-9]{9}", ErrorMessage = "Mobile Number must begin with 6,7,8 or 9")]
        public string MobileNumber { get; set; }







        [Required(ErrorMessage = "Password is required")]
        [StringLength(10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }







    }
}

 
    
        
  

 



    

