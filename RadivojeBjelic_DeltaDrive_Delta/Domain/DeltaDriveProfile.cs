using System;
using AutoMapper;
using RadivojeBjelic_DeltaDrive_Delta.Models;

namespace Domain
{
    public class DeltaDriveProfile : Profile
    {
        public DeltaDriveProfile()
        {
            CreateMap<Passenger, PassengerDTO>();
            CreateMap<Ride, RideDTO>()
                .ForMember(dest => dest.DriverFullName, opt => opt.MapFrom(src => $"{src.Driver.FirstName} {src.Driver.LastName}"))
                .ForMember(dest => dest.DriverBrand, opt => opt.MapFrom(src => $"{src.Driver.Brand}"))
                .ForMember(dest => dest.Score, opt => opt.MapFrom(src => $"{src.PassengerRating.Score}"))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => $"{src.PassengerRating.Comment}"));
        }
    }
}

