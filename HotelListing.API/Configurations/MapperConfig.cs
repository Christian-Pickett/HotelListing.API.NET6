using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Models.Country;
using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Configurations
{
    // in order to prevent security issues with users sending Unique IDs or other unneeded information, this mapping class
    // creates a mapping between the database context and a Data Transfer Object (DTO). The DTO holds only the relevant information
    // needed to perform the API call in question. For example, when making a HTTPS POST request, the user would be creating a record,
    // and only needs to send relevant information (E.G. the name of the record), not the ID of the record to be created.
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap(); 
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
        }
    }
}
