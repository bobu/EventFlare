using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFlare
{
    public class User
    {
        public string Handle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Twitter { get; set; }
        public string Email { get; set; }

        public User(string handle, string firstname, string lastname,
            string twitter, string email)
        {
            Handle = handle;
            FirstName = firstname;
            LastName = lastname;
            Twitter = twitter;
            Email = email;
        }
    }
}
