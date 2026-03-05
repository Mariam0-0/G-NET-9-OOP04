using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP04
{
    internal class VIPTicket : Ticket
    {
       
        //b.VIPTicket — prints the base ticket info, LoungeAccess, and ServiceFee.

        public bool LoungeAccess { get; set; }

        private decimal _serviceFee = 50;
        public decimal ServiceFee 
        {
            get { return _serviceFee; }
        }
        public VIPTicket(string movieName, decimal price , bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }
        public override void PrintTicket()
        {
            string access;
            if (LoungeAccess) access = "Yes";
            else access = "No";

            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP | Lounge: {access} | Service Fee: {ServiceFee} EGP");
        }
    }
}
