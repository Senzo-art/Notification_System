using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace bro
{
    public class GamePulseDBContext : DbContext
    {
        public GamePulseDBContext() : base("name=GamePulseDBContext")
        {
        }

        public DbSet<User> Users { get; set; }
       
    }
}