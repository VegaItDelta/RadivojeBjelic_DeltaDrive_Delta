using System;
using Microsoft.EntityFrameworkCore;
using RadivojeBjelic_DeltaDrive_Delta.Interfaces;
using RadivojeBjelic_DeltaDrive_Delta.Models;

namespace RadivojeBjelic_DeltaDrive_Delta.Repository
{
    public class PassengerRepository : IPassengerInterface
    {
        private readonly DriversDBContext _context;

        public PassengerRepository(DriversDBContext context)
        {
            this._context = context;
        }

        public void Add(Passenger passenger)
        {
            _context.Add(passenger);
            _context.SaveChanges();

        }

        public void Delete(Passenger passenger)
        {
            _context.Remove(passenger);
            _context.SaveChanges();
        }

        public IQueryable<Passenger> GetAll()
        {
            return _context.Passengers;
        }

        public Passenger GetById(Guid id)
        {
            return _context.Passengers.FirstOrDefault(r => r.PassengerId == id);
        }

        public void Update(Passenger passenger)
        {
            _context.Entry(passenger).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}

