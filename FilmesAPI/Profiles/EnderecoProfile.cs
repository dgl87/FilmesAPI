﻿using AutoMapper;
using FilmesAPI.Data.Enderecos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
        
    }
}