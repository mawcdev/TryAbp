using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAbp.App.Client
{
    public class ClientManager : DomainService, IClientManager
    {
        private readonly IRepository<Client> _repository;
        public ClientManager(IRepository<Client> repository)
        {
            _repository = repository;
        }
        public async Task<IdentityResult> CreateAsync(Client client)
        {
            var result = _repository.FirstOrDefault(x => x.Id == client.Id);
            if (result != null)
            {
                throw new UserFriendlyException("Already exist!");
            }
            else
            {

                await _repository.InsertAndGetIdAsync(client);
                return IdentityResult.Success;
            }
        }

        public async Task<IdentityResult> DeleteAsync(int id)
        {
            var result = _repository.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                await _repository.DeleteAsync(result);
                return IdentityResult.Success;
            }
            else
            {
                throw new UserFriendlyException("No Data Found!");

            }
        }

        public async Task<IEnumerable<Client>> GetAllAsync(string filter, string sort, int page, int pageSize, bool forExport)
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Client> GetByIdAsync(int id)
        {
            var result = await _repository.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
            {
                throw new UserFriendlyException("Already exist!");
            }
            else
            {

                return result;
            }
        }

        public async Task<IdentityResult> UpdateAsync(Client client)
        {
            try
            {
                await _repository.UpdateAsync(client);
                return IdentityResult.Success;
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException("Error Updating: " + ex.ToString());
            }
        }
    }
}
