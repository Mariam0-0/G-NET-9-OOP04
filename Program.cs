using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Net.Sockets;
using System;

namespace G_NET_9_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01: Theoretical Questions

            //Part 01 : Theoretical Questions

            #region Question 01
            // ===========================================================================================
            //Q1: What is the difference between static binding and dynamic binding? When does each one happen?
            // ===========================================================================================

            #endregion

            #region Question 01
            // ===========================================================================================
            //Q2 :  What is the difference between method overloading and method overriding?
            // ===========================================================================================

            #endregion

            #region Question 01
            // ===========================================================================================
            //Q3: What keywords are used for Method Overriding? What does each one mean ?
            // ===========================================================================================

            #endregion

            #endregion

            #region Part 02: Practical


            //Part 02 : Practical(Extending the Movie Ticket Booking System)
            //In the previous assignments, you built a Movie Ticket Booking System with inheritance, properties, and static members.Now you will apply polymorphism to make the system flexible and extensible.

            //What you need to build:
            //1.Refactor the base Ticket class:

            //a.Add a PrintTicket() method that prints: TicketId, MovieName, Price, PriceAfterTax.Child classes should be able to provide their own version of this method.
            //b.Add two versions of a SetPrice method — one that takes a decimal (sets price directly) and one that takes a decimal base price and a decimal multiplier(sets price = base × multiplier).

            //2. In each child class, provide its own version of PrintTicket():

            //a.StandardTicket — prints the base ticket info and the SeatNumber.
            //b.VIPTicket — prints the base ticket info, LoungeAccess, and ServiceFee.
            //c.IMAXTicket — prints the base ticket info and whether it is 3D.

            //3. In the Cinema class, update PrintAllTickets() so it loops through the Ticket[] array and calls PrintTicket() on each one.

            //4. Create a static method ProcessTicket(Ticket t) that takes any Ticket and calls PrintTicket() on it.

            //5. In Main:
            //a.Create a Cinema and open it.
            //b.Create one StandardTicket, one VIPTicket, and one IMAXTicket.
            //c.Test both versions of SetPrice on one ticket.
            //d.Add all tickets to the Cinema and call PrintAllTickets().
            //e.Call ProcessTicket() with one of the tickets.
            //f.Close the Cinema.

            #endregion


        }
    }
}
