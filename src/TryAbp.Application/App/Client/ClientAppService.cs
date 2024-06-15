using Abp.Authorization;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAbp.App.Client
{
    [AbpAllowAnonymous]
    public class ClientAppService :  TryAbpAppServiceBase,
        IClientAppService
    {
        private readonly IClientManager _clientManager;
        public ClientAppService(IClientManager clientManager)
        {
            _clientManager = clientManager;
        }
        public async Task<int> CreateClient(CreateClientDto input)
        {
            //Client
            var client = ObjectMapper.Map<Client>(input);

            CheckErrors(await _clientManager.CreateAsync(client));

            return client.Id;
        }

        public async Task<IEnumerable<ClientDto>> GetAllClients()
        {
            var getall = await _clientManager.GetAllAsync("", "", 0, 0, false);
            return ObjectMapper.Map<List<ClientDto>>(getall);
        }
    }
}
