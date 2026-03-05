using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP04
{
    internal class IMAXTicket : Ticket
    {
        
        //c.IMAXTicket — prints the base ticket info and whether it is 3D.

        public bool Is3D {  get; set; }
        public IMAXTicket(string movieName, decimal price, bool is3d) : base(movieName, price)
        {
            Is3D = is3d;
            if (is3d) 
            {
                price += 30;
            }
        }

        public override void PrintTicket()
        {
            string is3d;
            if (Is3D) is3d = "Yes";
            else is3d = "No";

            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP | IMAX 3D: {is3d}");
        }
        
    }
}
