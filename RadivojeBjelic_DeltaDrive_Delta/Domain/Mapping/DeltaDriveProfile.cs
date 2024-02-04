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
            CreateMap<Driver, DriverDTO>()
                .ForMember(dest => dest.Driver, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
            CreateMap<Ride, RideDTO>()
                .ForMember(dest => dest.DriverFullName, opt => opt.MapFrom(src => src.Driver != null ? $"{src.Driver.FirstName} {src.Driver.LastName}" : "N/A"))
                .ForMember(dest => dest.DriverBrand, opt => opt.MapFrom(src => src.Driver != null ? $"{src.Driver.Brand}" : "N/A"))
                .ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.Passenger != null ? src.PassengerRating.Score : 0))
                .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Passenger != null ? src.PassengerRating.Comment : string.Empty))
                .ForMember(dest => dest.PassengerFullName, opt => opt.MapFrom(src => src.Passenger != null ? $"{src.Passenger.FirstName} {src.Passenger.Lastname}" : "N/A")).ReverseMap();
            //CreateMap<Ride, BookRideDTO>();
            //CreateMap<RideDTO, Ride>();
        }
    }
}

