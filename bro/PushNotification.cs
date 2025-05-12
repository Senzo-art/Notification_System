using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notifications
{
    public class PushNotification : INotification
    {
        public string Send(string toUser, string message)
        {
            return $"[Push to {toUser}]: {message}";
        }


    }
}