using System;
using AutoMapper;

namespace RadivojeBjelic_DeltaDrive_Delta.Models
{
    public class PassengerProfile : Profile
    {
        public PassengerProfile()
        {
            CreateMap<Passenger, PassengerDTO>();
        }
    }
}

