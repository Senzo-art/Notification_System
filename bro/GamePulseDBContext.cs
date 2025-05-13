using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using bro.Models;

namespace Notifications
{
    public class GamePulseDBContext : DbContext
    {
        public GamePulseDBContext() : base("name=GamePulseDBContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subscriptions> Subscriptions { get; set; }
       
    }
}