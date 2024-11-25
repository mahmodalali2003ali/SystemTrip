using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAcecess
{
    public class RepositoryBooking : IRepository<Booking>
    {
        // Declare bookings as a private field to maintain state
        private List<Booking> bookings = new List<Booking>();

        // Expose the list of bookings via the Entities property
        public List<Booking> Entities => bookings;

        public void CreateOne(Booking booking)
        {
            bookings.Add(booking);
        }

        public void DeleteOne(int id)
        {
            var booking = GetOne(id);
            if (booking != null)
            {
                bookings.Remove(booking);
            }
        }

        public void GetAll()
        {
            foreach (Booking booking in bookings)
            {
                Console.WriteLine(booking.ToString());
            }
        }

        public void GetAlll()
        {
            throw new NotImplementedException();
        }

        public Booking GetOne(int id) => bookings.FirstOrDefault(b => b.Id == id);

        public void UpdateOne(int id, Booking updatedBooking)
        {
            var booking = GetOne(id);
            if (booking != null)
            {
                // Update the booking properties here
                booking.UserId = updatedBooking.UserId; // Assuming Booking has UserId property
                booking.TripId = updatedBooking.TripId; // Assuming Booking has TripId property
                // Add other properties as necessary
            }
        }
    }
}
