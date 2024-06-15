using Abp.Application.Services;
using TryAbp.MultiTenancy.Dto;

namespace TryAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

