using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify
{
    internal class Tikect
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public string HolderName { get; set; }  
        public string HolderEmail { get; set; }
        public bool ISBooked { get; set; }        
        public bool ISIssued { get; set; }

        public Tikect(int id, Event @event)
        {
            Id = id;
            Event = @event;
            ISIssued = true;
        }

    }
}
