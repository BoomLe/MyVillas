
using AutoMapper;
using My_VillaWeb.Models.Dtos;

namespace My_VillaWeb.AutoMap
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            
            CreateMap<VillaDTO, UpdateVillasDTO>().ReverseMap(); 

            CreateMap<VillaDTO, CreateVillasDTO>().ReverseMap();
            

            //Number
            
            CreateMap<VillanumberDTO, VillanumberCreateDTO>().ReverseMap();
            CreateMap<VillanumberDTO, VillanumberUpdateDTO>().ReverseMap();

     


        }
    }
}
