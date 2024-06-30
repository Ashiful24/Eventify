using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify
{
    internal class Venue
    {
        private static int nextId = 1;
        public int Id { get;  set; } 
        public string Name { get;  set; }
        public string Address { get;  set; }
        public int Capacity { get;  set; }

        public bool isAvalivable = true;

        public Venue(string Name, string Address, int capacity)
        {
            Id = nextId++;
            this.Name = Name;
            this.Address = Address;
            this.Capacity = capacity;
        }

       public void VenueDetails()
        {
            Console.WriteLine("Venue Id: "+Id);
            Console.WriteLine("Venue Name: "+Name);
            Console.WriteLine("Venue Addreess: "+Address);
            Console.WriteLine("Venue Capacity: "+Capacity);
            Console.WriteLine();
        }
    }
}
