using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class WalletFinancialTransaction
    {
        public int Id { get; set; }
        public int PatientWalletId { get; set; }
        public int AebtorAmount { get; set; }
        public int CreditorAmount { get; set; }
        public int CurrentInventory { get; set; }
        public int PaymentId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public PatientWallet PatientWallet { get; set; }
        public Payment Payment { get; set; }
    }
}
