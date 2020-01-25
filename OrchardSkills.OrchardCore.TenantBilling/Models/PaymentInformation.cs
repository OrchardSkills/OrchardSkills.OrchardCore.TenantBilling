namespace OrchardSkills.OrchardCore.TenantBilling.Models
{
    public class PaymentInformation
    {
        public bool Active { get; set; }
        public CreditCardInformation CreditCardInfo { get; set; }
    }
}