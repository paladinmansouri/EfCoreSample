using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class PatientWallet
    {
        public PatientWallet()
        {
            FinancialDocument = new HashSet<FinancialDocument>();
            WalletFinancialTransaction = new HashSet<WalletFinancialTransaction>();
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int Inventory { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Patient Patient { get; set; }
        public ICollection<FinancialDocument> FinancialDocument { get; set; }
        public ICollection<WalletFinancialTransaction> WalletFinancialTransaction { get; set; }
    }
}
