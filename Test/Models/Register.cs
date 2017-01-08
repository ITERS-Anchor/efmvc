using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Web.Mvc;

namespace Test.Models
{
    public class Register
    {
        
        public int Id { get; set; }
        [Required]
        [Remote("CheckUsername", "Register", ErrorMessage = "用户名已被注册")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "两次输入不一致")]
        public string Confirm { get; set; }
        public DateTime RegistTime { get; set; }
        public bool IsChecked { get; set; }
    }
}