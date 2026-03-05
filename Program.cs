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

            // Binding: the process of connecting the a method call to its actual implementation that will run

            // Static binding: means that the method call is resolved at compile time, it is faster and
            // it's only used when the compiler is 100% sure the method binding will not change

            // Dynamic binding: means the method call is resolved at runtime based on the actual object.
            // the runtime checks the actual object in memory to decide which method to call, which makes polymorphism work

            // When each one happens?
            // Static Binding => during compile time
            // Dynamic Binding => during runtime

            #endregion

            #region Question 02
            // ===========================================================================================
            //Q2 :  What is the difference between method overloading and method overriding?
            // ===========================================================================================

            // Method overloading: is using the same method name but different parameters list,
            // happens within the same class and it's resolved at compile time (Static binding)

            // Method overriding: is using the same method signature (virtual method) but overriding the implementation
            // in child classes using the keyword "override", it occurs with inheritance and is resolved during runtime
            // (dynamic binding)


            #endregion

            #region Question 03
            // ===========================================================================================
            //Q3: What keywords are used for Method Overriding? What does each one mean ?
            // ===========================================================================================

            // Virtual => used in the parent class to allow overriding for child classes

            // Override => used in child class to override a virtual method from the parent class

            // New => used in method hiding, it hides the method in base class and creates a new implementation for it,
            // which is not considered overriding

            #endregion

            #endregion

            #region Part 02: Practical

            #region Requirments

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

            #region Main

            //Cinema cinema = new Cinema();
            //Ticket ticket1 = new StandardTicket("Inception", 120, "A-5");
            //Ticket ticket2 = new VIPTicket("Avengers", 200, true);
            //Ticket ticket3 = new IMAXTicket("Dune", 180, false);
            //cinema.AddTicket(ticket1);
            //cinema.AddTicket(ticket2);
            //cinema.AddTicket(ticket3);

            //cinema.OpenCinema();
            //cinema.StartProjector();
            //Console.WriteLine();

            //Console.WriteLine("========= SetPrice Test =========");
            //ticket1.SetPrice(150);
            //Console.WriteLine($"Setting price directly: {ticket1.Price}");
            //ticket1.SetPrice(100, 1.5m);
            //Console.WriteLine($"Setting price with multiplier: 100 x 1.5 =  {ticket1.Price}");
            //Console.WriteLine();



            //cinema.PrintAllTickets();
            //Console.WriteLine();

            //Console.WriteLine("========= Process Single Ticket =========");
            //Cinema.ProcessTicket(ticket2);
            //Console.WriteLine();

            //cinema.CloseCinema();
            //cinema.StopProjector();
            #endregion


            #endregion

        }
    }
}
