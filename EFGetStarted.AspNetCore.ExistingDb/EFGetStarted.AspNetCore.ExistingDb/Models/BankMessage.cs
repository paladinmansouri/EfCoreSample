using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class BankMessage
    {
        public BankMessage()
        {
            BankMessageLocalize = new HashSet<BankMessageLocalize>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public int BankId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Bank Bank { get; set; }
        public ICollection<BankMessageLocalize> BankMessageLocalize { get; set; }
    }
}
