using System;
using OrchardSkills.OrchardCore.TenantBilling.Models;
using YesSql.Indexes;

namespace OrchardSkills.OrchardCore.TenantBilling.Indexes
{
    public class TenantBillingDetailsIndex : MapIndex
    {
        public string TenantId{ get; set; }
    }

    public class TenantIndexProvider : IndexProvider<Models.TenantBillingDetails>
    {
        public override void Describe(DescribeContext<Models.TenantBillingDetails> context)
        {
            context.For<TenantBillingDetailsIndex>()
                .Map(tenantBillingHistory =>
                {
                    return new TenantBillingDetailsIndex
                    {
                        TenantId = tenantBillingHistory.TenantId,
                    };
                });
        }
    }

}
