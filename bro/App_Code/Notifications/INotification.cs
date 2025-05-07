using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bro.App_Code.Notifications
{
    public interface INotification
    {
        string Send(string toUser, string message);
    }
}