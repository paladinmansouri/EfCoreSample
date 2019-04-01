using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class UserBankCard
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BankId { get; set; }
        public string CardNumber { get; set; }
        public string AccountNumber { get; set; }
        public string ShabaNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Bank Bank { get; set; }
        public User User { get; set; }
    }
}
