using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PingPong7.Models
{
    public class Account
    {

        [Key]
        public int LoginId { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}