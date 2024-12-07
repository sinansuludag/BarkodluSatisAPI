﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis.DLL.BarkodDBObjects
{
    public class User:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [Required(ErrorMessage ="Username is required.")]
        public  string? UserName { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string? Password { get; set; }
        public string? Email {  get; set; }
        public string? PhoneNumber {  get; set; }
    }
}