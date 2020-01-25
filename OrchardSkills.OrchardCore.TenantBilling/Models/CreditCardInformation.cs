using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrchardSkills.OrchardCore.TenantBilling.Models
{
    public class CreditCardInformation
    {
        public PaymentMethods PaymentMethod { get; set; }

        public int Last4Digits { get; set; }
    }
}
