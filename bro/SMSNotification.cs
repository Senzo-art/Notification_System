﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notifications
{
    public class SMSNotification : INotification
    {
        public string Send(string toUser, string message)
        {
            return $"[SMS to {toUser}]: {message}";
        }
    }

}