using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP04
{
    internal class StandardTicket : Ticket
    {
        //a.StandardTicket — prints the base ticket info and the SeatNumber.
        

        public string SeatNumber { get; set; }
        public StandardTicket(string movieName, decimal price, string seatNum) : base(movieName, price)
        {
            SeatNumber = seatNum;
        }
        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP | Seat: {SeatNumber}");
        }
        

    }
}
