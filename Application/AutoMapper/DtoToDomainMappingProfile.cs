using AutoMapper;
using Domain.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
            CreateMap<Minerio, MinerioComboDto>();
            CreateMap<MinerioComboDto, Minerio>();
        }
    }
}
