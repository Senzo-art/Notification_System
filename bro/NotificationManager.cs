using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Notifications;

namespace bro
{
    public class NotificationManager
    {
      
            private readonly List<User> _users;

            public NotificationManager(List<User> users)
            {
                _users = users;
            }

            // Trigger Notification for New Game Release
            public void NewGameRelease(string gameName)
            {
                string message = $"🚀 New release: {gameName} is out!";
                NotifyUsers(message, (user) => user.NotifyByEmail || user.NotifyByPush);
            }

            // Trigger Notification for Game Update or Patch
            public void GameUpdate(string gameName)
            {
                string message = $"🛠 Update for {gameName} is now live!";
                NotifyUsers(message, (user) => user.NotifyByEmail || user.NotifyByPush);
            }

            // Trigger Notification for Sale or Price Drop
            public void SaleOrPriceDrop(string gameName)
            {
                string message = $"🔥 Sale on {gameName}: 40% off!";
                NotifyUsers(message, (user) => user.NotifyBySMS || user.NotifyByEmail);
            }

            // Trigger Notification for In-game Event
            public void InGameEvent(string gameName)
            {
                string message = $"⚔ {gameName} event starts in 30 mins!";
                NotifyUsers(message, (user) => user.NotifyByPush || user.NotifyBySMS);
            }

            // Trigger Notification for Wishlist Item Sale
            public void WishlistSale(string gameName)
            {
                string message = $"🎁 Your wishlist game {gameName} is on sale!";
                NotifyUsers(message, (user) => user.NotifyByEmail || user.NotifyByPush);
            }

            // Helper method to notify users based on preferences
            private void NotifyUsers(string message, Func<User, bool> filter)
            {
                foreach (var user in _users.Where(filter))
                {
                    if (user.NotifyByEmail)
                        user.Subscribe(new EmailNotification());
                    if (user.NotifyByPush)
                        user.Subscribe(new PushNotification());
                    if (user.NotifyBySMS)
                        user.Subscribe(new SMSNotification());

                    // Send the notification
                    string notificationResult = user.ReceiveMessage(message);
                    Console.WriteLine(notificationResult);
                }
            }
        }

    
}