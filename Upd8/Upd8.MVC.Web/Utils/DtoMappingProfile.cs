using AutoMapper;
using Upd8.Core.Domain.Entities;
using Upd8.MVC.Web.Models;

namespace Upd8.MVC.Web.Utils
{
    public class DtoMappingProfile: Profile
    {

        public DtoMappingProfile()
        {
            CreateMap<ClienteModel, Cliente>();
            CreateMap<Cliente, ClienteModel>();
        }
    }
}
