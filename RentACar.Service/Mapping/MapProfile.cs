using AutoMapper;
using RentACar.Core;
using RentACar.Core.DTOs;

namespace RentACar.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<CarUpdateDto, Car>().ReverseMap();
        }
    }
}
