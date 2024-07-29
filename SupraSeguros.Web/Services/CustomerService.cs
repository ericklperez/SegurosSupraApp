using SupraSeguros.Web.Extensions;
using SupraSeguros.Web.Models.Api;

namespace SupraSeguros.Web.Services
{
    public class CustomerService : IServiceAsync<Customer>
    {
        private readonly HttpClient _client;

        public CustomerService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            var response = await _client.GetAsync($"{id}");
            return await response.ReadContentAs<Customer>();
        }

        public async Task<IReadOnlyList<Customer>> ListAllAsync()
        {
            var response = await _client.GetAsync("list");
            return await response.ReadContentAs<IReadOnlyList<Customer>>();
        }

        public async Task<Customer> AddAsync(Customer entity)
        {
            var response = await _client.PostAsJson("create", entity);
            return await response.ReadContentAs<Customer>();
        }

        public async Task UpdateAsync(Customer entity)
        {
            await _client.PutAsJson($"{entity.ClienteId}", entity);
        }

        public async Task DeleteAsync(Customer entity)
        {
            await _client.DeleteAsync($"{entity.ClienteId}");
        }

        public async Task<IReadOnlyList<Customer>> GetPagedReponseAsync(int page, int size)
        {
            var response = await _client.GetAsync($"paged?page={page}&size={size}");
            return await response.ReadContentAs<IReadOnlyList<Customer>>();
        }
    }

}
