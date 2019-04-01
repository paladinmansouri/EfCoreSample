using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Visitor
    {
        public Visitor()
        {
            LegalContract = new HashSet<LegalContract>();
            PersonContract = new HashSet<PersonContract>();
        }

        public int UserId { get; set; }
        public int? ProfitLetterGroupId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ProfitLetterGroup ProfitLetterGroup { get; set; }
        public ICollection<LegalContract> LegalContract { get; set; }
        public ICollection<PersonContract> PersonContract { get; set; }
    }
}
