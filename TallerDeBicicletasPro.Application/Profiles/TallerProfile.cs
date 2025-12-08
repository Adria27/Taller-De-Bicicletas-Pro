using AutoMapper;
using TallerDeBicicletasPro.Application.DTOs;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Profiles
{
    public class TallerProfile : Profile
    {
        public TallerProfile()
        {
           
            CreateMap<Bicicleta, BicicletaDto>().ReverseMap();

            
            CreateMap<Cliente, ClienteDto>().ReverseMap();

            CreateMap<Mecanico, MecanicoDto>().ReverseMap();

            CreateMap<Reparacion, ReparacionDto>().ReverseMap();
        }
    }
}
