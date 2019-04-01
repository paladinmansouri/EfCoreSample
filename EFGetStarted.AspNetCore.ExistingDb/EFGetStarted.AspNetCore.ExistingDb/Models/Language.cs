using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Language
    {
        public Language()
        {
            BreadCrumbLocalize = new HashSet<BreadCrumbLocalize>();
            FaqCategoryLocalize = new HashSet<FaqCategoryLocalize>();
            FaqLocalize = new HashSet<FaqLocalize>();
            FormMessageLocalize = new HashSet<FormMessageLocalize>();
            GeneralContentLocalize = new HashSet<GeneralContentLocalize>();
            GeneralContentTypeLocalize = new HashSet<GeneralContentTypeLocalize>();
            NewsCategoryLocalize = new HashSet<NewsCategoryLocalize>();
            NewsLocalize = new HashSet<NewsLocalize>();
            UiPageLocalize = new HashSet<UiPageLocalize>();
        }

        public int Id { get; set; }
        public bool IsDefault { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public bool Rtl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<BreadCrumbLocalize> BreadCrumbLocalize { get; set; }
        public ICollection<FaqCategoryLocalize> FaqCategoryLocalize { get; set; }
        public ICollection<FaqLocalize> FaqLocalize { get; set; }
        public ICollection<FormMessageLocalize> FormMessageLocalize { get; set; }
        public ICollection<GeneralContentLocalize> GeneralContentLocalize { get; set; }
        public ICollection<GeneralContentTypeLocalize> GeneralContentTypeLocalize { get; set; }
        public ICollection<NewsCategoryLocalize> NewsCategoryLocalize { get; set; }
        public ICollection<NewsLocalize> NewsLocalize { get; set; }
        public ICollection<UiPageLocalize> UiPageLocalize { get; set; }
    }
}
