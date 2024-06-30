using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Eventify
{
    internal class Organizer
    {
        private static int nextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        public bool isAvaile = true;

        public Organizer(string name, string contactInfo)
        {
            Id = nextId++;
            Name = name;
            ContactInfo = contactInfo;
        }

        public void OrganizerDetails()
        {
            Console.WriteLine("Organizer Id: " + Id);
            Console.WriteLine("Organizer Name: " + Name);
            Console.WriteLine("Organizer Contact: " + ContactInfo);
            Console.WriteLine();
        }
    }
}
