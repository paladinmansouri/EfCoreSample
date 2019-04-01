using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class UiPage
    {
        public UiPage()
        {
            BreadCrumb = new HashSet<BreadCrumb>();
            UiPageLocalize = new HashSet<UiPageLocalize>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<BreadCrumb> BreadCrumb { get; set; }
        public ICollection<UiPageLocalize> UiPageLocalize { get; set; }
    }
}
