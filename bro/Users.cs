using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bro
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }


        public bool NotifyByEmail { get; set; }
        public bool NotifyBySMS { get; set; }
        public bool NotifyByPush { get; set; }
    }
}



