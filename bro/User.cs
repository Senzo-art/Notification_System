﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using Notifications;

namespace Notifications
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        private List<INotification> _subscriptions = new List<INotification>();

        public void Subscribe(INotification notification)
        {
            _subscriptions.Add(notification);
        }

        public string ReceiveMessage(string message)
        {
            StringBuilder output = new StringBuilder();
            foreach (var method in _subscriptions)
            {
                string recipient = GetRecipientForNotifier(method);
                output.AppendLine(method.Send(recipient, message));
            }
            return output.ToString();
        }

        private string GetRecipientForNotifier(INotification method)
        {
            if (method is EmailNotification)
                return Email;
            if (method is SMSNotification)
                return PhoneNumber ?? "UnknownNumber";
            if (method is PushNotification)
                return Name; // or device token if available

            return "UnknownRecipient";
        }

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



