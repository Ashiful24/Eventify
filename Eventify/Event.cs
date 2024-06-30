using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify
{
    internal class Event
    {
       

        public int Id { get;  set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Venue Venue { get; set; }
        public Organizer Organizer { get; set; }
        public List<Participant> Participants { get; set; }

       
        public void Details()
        {
            Console.WriteLine("Id: "+Id);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("About: "+Description);
            Console.WriteLine("Date: "+Date);
            Console.WriteLine("Place: "+Venue.Name);
            Console.WriteLine("Organizer: "+Organizer.Name);
        }
    }
}
