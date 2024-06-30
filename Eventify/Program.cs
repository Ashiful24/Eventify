using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Eventify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var venue1 = new Venue("Sadinota 71", "Araihazr", 500);
            var venue2 = new Venue("Confarenc Hall", "Araihazr", 200);
            var venue3 = new Venue("Oditirium", "Araihazr", 400);

            var organizer1 = new Organizer("Angkon", "01609884769");
            var organizer2 = new Organizer("Ashiful", "ashiful35-3017@diu.edu.bd");

            var management = new EventMangement();
            management.AddVenue(venue1);
            management.AddVenue(venue2);
            management.AddVenue(venue3);

            management.AddOrganizer(organizer1);
            management.AddOrganizer(organizer2);



            UserMenu(management);
        }

       


        static void UserMenu(EventMangement mangement)
        {
            while (true)
            {
                Console.WriteLine("1. See Availble Venue");
                Console.WriteLine("2. See Availble Organizer");
                Console.WriteLine("3. Create Event");
                Console.WriteLine("4. Event Deatails");
                Console.WriteLine("5. Issue Ticket");
                Console.WriteLine("6. Book Ticket");
                Console.WriteLine("Choose An option: ");
                var option = Console.ReadLine();

                if (option == "1")
                {
                    mangement.SearchAvailableVenue();
                }
                else if (option == "2")
                {
                    mangement.SearchAvailableOrnaizer();
                }
                else if (option == "3")
                {
                    Console.WriteLine("Enter Event Name: ");
                    var eventName = Console.ReadLine();
                    Console.WriteLine("Write Event Description: ");
                    var eventDesription = Console.ReadLine();
                    Console.WriteLine("Enter Event date (yyyy-mm-dd)");
                    var date = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Vanue Id: ");
                    int id = int.Parse(Console.ReadLine());
                    var vanue = mangement.BookVenue(id);
                    Console.WriteLine("Enter Organizer Id: ");
                    int Id = int.Parse(Console.ReadLine());
                    var organizer = mangement.BookOrganizer(Id);

                    Event @event = new Event
                    {
                          
                          Id= new Random().Next(1000),
                          Name = eventName,
                          Description = eventDesription,
                          Date = date,
                          Venue = vanue,
                          Organizer = organizer

                    };

                    mangement.MakeEvent(@event);

                }

                else if (option == "4")
                {
                    mangement.EventDetails();
                    
                }

                else if (option == "5")
                {
                    Console.WriteLine("Enter Event Id");
                    var id = int.Parse(Console.ReadLine());

                    mangement.IssueTicket(id);

                }
                else if (option == "6")
                {
                    Participant participant = new Participant("Istiuk", "istiuk2500@gmail.com");
                   
                    Console.WriteLine("Enter Event Id:");
                    var Eid = int.Parse(Console.ReadLine());
                    mangement.BookTicket(Eid,participant);
                }

            }
        }



    }
}
