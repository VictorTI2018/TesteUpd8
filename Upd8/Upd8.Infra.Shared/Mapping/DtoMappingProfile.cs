using AutoMapper;
using Upd8.Core.Domain.Dtos;
using Upd8.Core.Domain.Entities;

namespace Upd8.Infra.Shared.Mapping
{
    public class DtoMappingProfile: Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<ClienteDto, Cliente>();
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
