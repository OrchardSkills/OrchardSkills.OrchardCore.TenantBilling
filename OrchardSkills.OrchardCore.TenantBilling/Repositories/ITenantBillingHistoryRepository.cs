using System.Threading.Tasks;
using OrchardSkills.OrchardCore.TenantBilling.Models;

namespace OrchardSkills.OrchardCore.TenantBilling.Tenants.Repositories
{
    public interface ITenantBillingHistoryRepository
    {
        Task CreateAsync(TenantBilling.Models.TenantBillingDetails history);
        Task DeleteAsync(string tenantId);
        Task<TenantBilling.Models.TenantBillingDetails> GetTenantBillingHistoryById(string id);
    }
}