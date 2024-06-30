using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify
{
    internal class EventMangement
    {
        List<Venue> Venues = new List<Venue>();
        List<Organizer> Organizers = new List<Organizer>();
        List<Event> Events = new List<Event>();
        List<Tikect> Tikects = new List<Tikect>();

        public void AddVenue(Venue venue)
        {
            Venues.Add(venue);
        }

        public void RemoveVenue(Venue venue)
        {
            Venues.Remove(venue);
        }

        public void SearchAvailableVenue()
        {
            foreach (var venue in Venues)
            {
                if (venue.isAvalivable == true)
                {
                    venue.VenueDetails();
                }
            }
        }

        public Venue BookVenue(int id)
        {
            var venue = Venues.Find(x => x.Id == id);

            if (venue.isAvalivable == true)
            {
                venue.isAvalivable = false;
                Console.WriteLine("Vanue book sucessfull");
                return venue;
            }
            else
            {
                Console.WriteLine("Vanue is not availble");
                return null;

            }
        }

        public void AddOrganizer(Organizer organizer)
        {
            Organizers.Add(organizer);
        }

        public void RemoveOrganizer(Organizer organizer)
        {
            Organizers.Remove(organizer);
        }

        public void SearchAvailableOrnaizer()
        {
            foreach (var organizer in Organizers)
            {
                if (organizer.isAvaile == true)
                {
                    organizer.OrganizerDetails();
                }
            }
        }

        public Organizer BookOrganizer(int id)
        {
            var organizer = Organizers.Find(x => x.Id == id);
            if (organizer.isAvaile == true)
            {
                organizer.isAvaile = false;
                Console.WriteLine("Vanue book sucessfull");
                return organizer;
            }
            else
            {
                Console.WriteLine("Organizer is not availbel.");
                return null;
            }
        }

        public void MakeEvent(Event envent)
        {
            Events.Add(envent);
            Console.WriteLine("Envent Make Succefull");
        }

        public void EventDetails()
        {
            foreach (var item in Events)
            {
                item.Details();
            }
        }

        public void IssueTicket(int id)
        {
            var @event = Events.Find(r=>r.Id == id);
            int numberOfTickets = @event.Venue.Capacity;

            for (int i = 0; i < numberOfTickets; i++)
            {
                var ticket = new Tikect(Tikects.Count+1, @event);
                Tikects.Add(ticket);

            }

            Console.WriteLine($"{numberOfTickets} tikets issued for event {@event.Name}");
        }

       public void BookTicket ( int @eventId, Participant participant)
        {
            Tikect ticket = Tikects.FirstOrDefault(t=> t.Event.Id == @eventId && t.ISIssued && !t.ISBooked );

            if (ticket == null)
            {
                Console.WriteLine("Ticket not availble for booking");
                return;
            }

            ticket.HolderName = participant.Name;
            ticket.HolderEmail = participant.Email;
            ticket.ISBooked = true;
            Console.WriteLine($"Tiket booked succesfully for event {ticket.Event.Name}");

        }
        

    }
}
