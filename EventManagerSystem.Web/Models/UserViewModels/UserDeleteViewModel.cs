﻿using EventManagerSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagerSystem.Web.Models
{
    public class UserDeleteViewModel : BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string ImgURL { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string ValidationCode { get; set; }
    }
}