using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP04

{
    internal class Cinema
    {

        #region Requirments
        //3. In the Cinema class, update PrintAllTickets() so it loops through the Ticket[] array and calls PrintTicket() on each one.
        //4. Create a static method ProcessTicket(Ticket t) that takes any Ticket and calls PrintTicket() on it.

        #endregion

        #region Old Methods/Fields

        public string CinemaName { get; set; }
        public Projector projector = new Projector();


        private Ticket[] tickets = new Ticket[20];

        public void OpenCinema()
        {
            Console.WriteLine("======= Cinema Opened =======");
        }

        public void CloseCinema()
        {
            Console.WriteLine("======= Cinema Closed =======");
        }

        public void StartProjector()
        {
            projector.Start();
        }

        public void StopProjector()
        {
            projector.Stop();
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < 20; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region New/ Updated Methods

        public void PrintAllTickets()
        {
            Console.WriteLine("======= All Tickets =======");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    tickets[i].PrintTicket();
                }
                else
                    continue;
            }

        }

        public static void ProcessTicket(Ticket t)
        {
            t.PrintTicket();
        }

        #endregion

    }
}

