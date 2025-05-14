using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bro.Models
{
    public class Subscriptions
        
    {
        public int Id { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public string PushDevice { get; set; }

        public bool NotifyByEmail { get; set; }
        public bool NotifyBySMS { get; set; }
        public bool NotifyByPush { get; set; }
        public DateTime DateSubscribed { get; set; }

    }
}