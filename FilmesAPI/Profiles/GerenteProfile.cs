using AutoMapper;
using FilmesAPI.Data.Dtos.Gerentes;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<Gerente, ReadGerenteDto>();
            CreateMap<CreateGerenteDto, Gerente>();
        }
    }
}