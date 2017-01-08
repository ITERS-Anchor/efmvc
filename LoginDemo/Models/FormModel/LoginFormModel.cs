using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginDemo.Models
{
    public class LoginFormModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}