using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eshopping_webapi.Models;
using Eshopping_webapi.Repoistory;

namespace Eshopping_webapi.Repoistory
{
    public class UserRepository : IDataRepository<UserTable>
    {
        shoppingzoneEntities _userdbcontext;
        public UserRepository(shoppingzoneEntities userdbcontext)
        {
            _userdbcontext = userdbcontext;



        }
        public void Add(UserTable newuser)
        {
            _userdbcontext.UserTables.Add(newuser);
            _userdbcontext.SaveChanges();
        }
        public IEnumerable<UserTable> GetAll()
        {
            return _userdbcontext.UserTables.ToList();
        }






    }
}