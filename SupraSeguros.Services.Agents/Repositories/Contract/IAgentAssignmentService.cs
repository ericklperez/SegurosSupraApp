
namespace SupraSeguros.Services.Agents.Repositories.Contract
{
    public interface IAgentAssignmentService
    {
        Task AssignAgentToCustomerAsync(Guid clienteId, Guid agenteId);
        Task<IEnumerable<Agente>> GetAllAgentsAsync();
        Task<IEnumerable<Services.Customer.Entities.Customer>> GetAllCustomersByAgentAsync(Guid agenteId);
    }

}
