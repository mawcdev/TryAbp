using System.Threading.Tasks;
using Abp.Application.Services;
using TryAbp.Sessions.Dto;

namespace TryAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
