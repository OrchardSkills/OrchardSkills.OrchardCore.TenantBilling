using OrchardSkills.OrchardCore.TenantBilling.Indexes;
using OrchardCore.Data.Migration;

namespace OrchardSkills.OrchardCore.TenantBilling
{
    public class Migrations : DataMigration
    {
        public int Create()
        {
            SchemaBuilder.CreateMapIndexTable(nameof(TenantBillingDetailsIndex), table => table
                .Column<string>("TenantId")
            );

            return 1;
        }
    }
}