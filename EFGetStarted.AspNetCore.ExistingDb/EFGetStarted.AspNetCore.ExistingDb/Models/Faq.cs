using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Faq
    {
        public Faq()
        {
            FaqLocalize = new HashSet<FaqLocalize>();
        }

        public int Id { get; set; }
        public int FaqCategoryId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public FaqCategory FaqCategory { get; set; }
        public ICollection<FaqLocalize> FaqLocalize { get; set; }
    }
}
