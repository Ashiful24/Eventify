using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify
{
    internal class Participant
    {
        private static int nextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }      
        public string Email { get; set; }

        public Participant(string Name, string email)
        {
            Id = nextId++;
            this.Name= Name;         
            Email = email;
        }
    }
}
