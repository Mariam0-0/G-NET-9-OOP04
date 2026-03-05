using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP04
{
    internal class Ticket
    {
        #region Requirments
        //1.Refactor the base Ticket class:

        //a.Add a PrintTicket() method that prints: TicketId, MovieName, Price, PriceAfterTax.Child classes should be able to provide their own version of this method.
        //b.Add two versions of a SetPrice method — one that takes a decimal (sets price directly) and one that takes a decimal base price and a decimal multiplier(sets price = base × multiplier).


        #endregion

        #region Old Methods & Fields


        private string _movieName;
        public string MovieName 
        {
            get { return _movieName; }
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Movie Name cannot be null or empty");
                    return;
                }
                _movieName = value;
            } 
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Price must be > 0");
                    return;
                }
                _price = value;
            }
        }

        private static int ticketCounter = 0;
        private int _ticketId;
        public int TicketId
        {
            get { return _ticketId; }
        }

        
        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            _ticketId = ++ticketCounter;
        }
        
        public decimal PriceAfterTax
        {
            get { return _price + _price * 0.14m; }
        }
        

      
        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }

        #endregion

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{_ticketId} | {MovieName} | Price: {Price} | After Tax: {PriceAfterTax}");
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }
        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }

    }
}
