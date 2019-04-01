using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class FaqCategory
    {
        public FaqCategory()
        {
            Faq = new HashSet<Faq>();
            FaqCategoryLocalize = new HashSet<FaqCategoryLocalize>();
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<Faq> Faq { get; set; }
        public ICollection<FaqCategoryLocalize> FaqCategoryLocalize { get; set; }
    }
}
