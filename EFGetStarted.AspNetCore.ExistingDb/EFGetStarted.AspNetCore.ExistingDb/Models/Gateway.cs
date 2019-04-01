using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Gateway
    {
        public Gateway()
        {
            Bank = new HashSet<Bank>();
            GatewayParam = new HashSet<GatewayParam>();
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string SendUrl { get; set; }
        public string BackUrl { get; set; }
        public int BankId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Bank BankNavigation { get; set; }
        public ICollection<Bank> Bank { get; set; }
        public ICollection<GatewayParam> GatewayParam { get; set; }
        public ICollection<Payment> Payment { get; set; }
    }
}
