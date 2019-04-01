using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Payment
    {
        public Payment()
        {
            WalletFinancialTransaction = new HashSet<WalletFinancialTransaction>();
        }

        public int Id { get; set; }
        public int GatewayId { get; set; }
        public long UserId { get; set; }
        public int BankStatusCode { get; set; }
        public long AuthId { get; set; }
        public string CartId { get; set; }
        public double Amount { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? CallBackDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Gateway Gateway { get; set; }
        public ICollection<WalletFinancialTransaction> WalletFinancialTransaction { get; set; }
    }
}
