using EventManagerSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagerSystem.Data.Entity
{
    public class EventManagerSystemContext :DbContext
    {
        public EventManagerSystemContext() : base ("name=EventManagerSystemDB"){

        } 

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

