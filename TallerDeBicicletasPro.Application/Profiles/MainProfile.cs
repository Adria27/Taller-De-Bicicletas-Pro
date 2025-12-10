using AutoMapper;
using TallerDeBicicletasPro.Application.DTOs;
using TallerDeBicicletasPro.Domain.Entities;

namespace TallerDeBicicletasPro.Application.Mapping.Profiles
{
    public class MainProfile : Profile
    {
        public MainProfile()
        {
            // ============================
            //         BICICLETAS
            // ============================
            CreateMap<Bicicleta, BicicletaDto>().ReverseMap();

            // ============================
            //          CLIENTES
            // ============================
            CreateMap<Cliente, ClienteDto>().ReverseMap();

            // ============================
            //          MECÁNICOS
            // ============================
            CreateMap<Mecanico, MecanicoDto>().ReverseMap();

            
            //        REPARACIONES
            // ============================
            CreateMap<Reparacion, ReparacionDto>().ReverseMap();
        }
    }
}
