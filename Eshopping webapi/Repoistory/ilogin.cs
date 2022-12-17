using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshopping_webapi.Repoistory
{
    internal interface Ilogin
    { 
    User VerifyLogin(string EmailID, string Password);
    
    }
}
