using SupraSeguros.Services.Customer.Entities;

namespace SupraSeguros.Services.Agents.Repositories.Contract
{
    public interface IAgentAssignmentService
    {
        Task AssignAgentToCustomerAsync(Guid clienteId, Guid agenteId);
        Task<IEnumerable<Agente>> GetAllAgentsAsync();
        Task<IEnumerable<Customer.Entities.Customer>> GetAllCustomersByAgentAsync(Guid agenteId);
    }

}
