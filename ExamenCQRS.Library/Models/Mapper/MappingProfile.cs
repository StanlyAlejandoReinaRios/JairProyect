using AutoMapper;
using ExamenCQRS.Library.Models.Dto_s;
using ExamenCQRS.Library.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCQRS.Library.Models.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ExamenUsuarioDTO, ExamenUsuarios>()
                .ForMember(o => o.Nombre, o => o.MapFrom(d => d.Name))
                .ForMember(o => o.Otro, o => o.MapFrom(d => d.other)
                
            );
        }
    }
}
