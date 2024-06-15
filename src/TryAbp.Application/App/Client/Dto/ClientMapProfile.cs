using Abp.Authorization.Roles;
using Abp.Authorization;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryAbp.Authorization.Roles;
using TryAbp.Roles.Dto;

namespace TryAbp.App.Client.Dto
{
    internal class ClientMapProfile : Profile
    {
        public ClientMapProfile()
        {
            CreateMap<CreateClientDto, Client>().ReverseMap();
            CreateMap<ClientDto, Client>().ReverseMap();

        }
    }
}
