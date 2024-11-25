using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAcecess
{
    public class RepositoryTrip : IRepository<Trip>
    {
        
        private List<Trip> trips = new List<Trip>();

        public List<Trip> Entities => trips;

        public void CreateOne(Trip trip)
        {
            trips.Add(trip);
        }

        public void UpdateOne(int id, Trip updatedTrip)
        {
            var trip = GetOne(id);
            if (trip != null)
            {
                
                trip.Title = updatedTrip.Title; 
                trip.Description = updatedTrip.Description; 
                trip.StartDate = updatedTrip.StartDate; 
                trip.EndDate = updatedTrip.EndDate; 
            }
        }

        public void DeleteOne(int id)
        {
            var trip = GetOne(id);
            if (trip != null)
            {
                trips.Remove(trip);
            }
        }

        public List<Trip> GetAll()
        {
            return   trips;
        }

        public Trip GetOne(int id)
        {
            return trips.FirstOrDefault(t => t.Id == id);
        }

        public void GetAlll()
        {
            foreach (var trip in trips)
            {
                Console.WriteLine(trip.ToString());
            }
        }
    }
}
