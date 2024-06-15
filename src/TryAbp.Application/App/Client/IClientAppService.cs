using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAbp.App.Client
{
    public interface IClientAppService : IApplicationService
    {
        //Task<IEnumerable<GetClientOutput>> GetAllClients();
        Task<int> CreateClient(CreateClientDto input);
        Task<IEnumerable<ClientDto>> GetAllClients();
        //Task UpdateClient(UpdateClientInput input);
        //Task DeleteClient(DeleteClientInput input);
        //Task<GetClientOutput> GetClient(GetClientInput input);
    }
}
