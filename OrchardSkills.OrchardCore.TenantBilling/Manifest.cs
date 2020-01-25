using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "TenantBilling",
    Author = "Orchard Skills",
    Website = "https://OrchardSkills.com",
    Version = "1.0.0",
    Category = "Accounting"
)]

[assembly: Feature(
    Id = "OrchardSkills.OrchardCore.TenantBilling",
    Name = "TenantBilling",
    Category = "Accounting",
    Description = "Allows users to view and update billing",
    Dependencies = new[]
    {
        "OrchardCore.Tenants",
    }
)]
