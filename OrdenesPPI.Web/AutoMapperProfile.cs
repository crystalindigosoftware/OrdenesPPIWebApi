using AutoMapper;
using OrdenesPPI.Core.Entities;
using OrdenesPPI.Core.DTOs;
using OrdenesPPI.Web.Models;

namespace OrdenesPPI.Web
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {

            //Entities to Models
            CreateMap<Tipoactivo, TipoactivoModel>();

            CreateMap<Activo, ActivoModel>();

            CreateMap<Estado, EstadoModel>();

            CreateMap<Cuenta, CuentaModel>();


            //Models to Entities

            CreateMap<TipoactivoModel, Tipoactivo>();

            CreateMap<ActivoModel, Activo>();

            CreateMap<EstadoModel, Estado>();

            CreateMap<CuentaModel, Cuenta>();


        }

    }
}
