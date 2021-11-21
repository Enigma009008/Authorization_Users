using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth_Users.Model
{
   public class DataUsers
   {
        public string Username { get; set; }

        public string Password { get; set; }

        public DataUsers(string username, string password)
        {
            Username = username;
            Password = password;
        }

        internal static object FirstOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }

}
