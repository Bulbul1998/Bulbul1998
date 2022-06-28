using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceEE.ViewModel
{
    public class RegisterViewModel
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsUserExits { get; set; }
    }
}
