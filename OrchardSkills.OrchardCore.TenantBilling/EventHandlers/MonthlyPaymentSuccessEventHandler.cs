using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrchardSkills.OrchardCore.TenantBilling.Models;
using OrchardSkills.OrchardCore.TenantBilling.Tenants.Repositories;

namespace OrchardSkills.OrchardCore.TenantBilling.EventHandlers
{
    public class MonthlyPaymentSuccessEventHandler : IPaymentSuccessEventHandler
    {
        private readonly ITenantBillingHistoryRepository _tenantBillingRepo;
        public MonthlyPaymentSuccessEventHandler(ITenantBillingHistoryRepository tenantBillingRepo)
        {
            _tenantBillingRepo = tenantBillingRepo;
        }

        public async Task PaymentSuccess(string tenantId, DateTime paymentMonth, decimal amount)
        {
            //Check if billing history exists
            var tenantBillingHistory = await _tenantBillingRepo.GetTenantBillingHistoryById(tenantId);
            if(tenantBillingHistory==null)
            {
               tenantBillingHistory = new Models.TenantBillingDetails(tenantId);
            }
            CreditCardInformation creditCardInfo = new CreditCardInformation
            {
                PaymentMethod = PaymentMethods.Card
            };
            tenantBillingHistory.AddMonthlyBill(paymentMonth, amount, creditCardInfo);

            await _tenantBillingRepo.CreateAsync(tenantBillingHistory);
        }
    }
}
