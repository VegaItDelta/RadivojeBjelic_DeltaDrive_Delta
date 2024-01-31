using System;
using RadivojeBjelic_DeltaDrive_Delta.Models;

namespace RadivojeBjelic_DeltaDrive_Delta.Interfaces
{
    public interface IPassengerInterface
    {
        IQueryable<Passenger> GetAll();
        Passenger GetById(Guid id);
        void Add(Passenger passenger);
        void Update(Passenger passenger);
        void Delete(Passenger passenger);
    }
}

