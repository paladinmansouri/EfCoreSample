using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Bank
    {
        public Bank()
        {
            BankLocalize = new HashSet<BankLocalize>();
            BankMessage = new HashSet<BankMessage>();
            GatewayNavigation = new HashSet<Gateway>();
            UserBankCard = new HashSet<UserBankCard>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public int? GatewayId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Gateway Gateway { get; set; }
        public ICollection<BankLocalize> BankLocalize { get; set; }
        public ICollection<BankMessage> BankMessage { get; set; }
        public ICollection<Gateway> GatewayNavigation { get; set; }
        public ICollection<UserBankCard> UserBankCard { get; set; }
    }
}
