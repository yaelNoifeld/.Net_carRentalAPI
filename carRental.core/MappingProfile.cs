using AutoMapper;
using carRental.core.DTOs;
using carRental.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRental.core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<Rent, RentDto>().ReverseMap();
            CreateMap<Renter, RentDto>().ReverseMap();
        }
    }
}
