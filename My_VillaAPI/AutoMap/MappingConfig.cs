using AutoMapper;
using My_VillaAPI.Models;
using My_VillaAPI.Models.Dtos;

namespace My_VillaAPI.AutoMap
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, CreateVillasDTO>().ReverseMap();
            CreateMap<Villa, UpdateVillasDTO>().ReverseMap();

            //Number
            CreateMap<VillaNumber, VillanumberDTO>().ReverseMap();
            CreateMap<VillaNumber, VillanumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillanumberUpdateDTO>().ReverseMap();
            //User
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();

        }
    }
}
