using Abp.Domain.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryAbp.Authorization.Users;

namespace TryAbp.App.Client
{
    public interface IClientManager : IDomainService
    {
        Task<IdentityResult> CreateAsync(Client client);
        Task<IdentityResult> UpdateAsync(Client client);
        Task<IdentityResult> DeleteAsync(int id);
        Task<Client> GetByIdAsync(int id);
        Task<IEnumerable<Client>> GetAllAsync(string filter, string sort, int page, int pageSize, bool forExport);
    }
}
