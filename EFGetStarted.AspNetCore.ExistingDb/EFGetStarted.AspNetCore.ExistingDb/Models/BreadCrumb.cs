using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class BreadCrumb
    {
        public BreadCrumb()
        {
            BreadCrumbLocalize = new HashSet<BreadCrumbLocalize>();
        }

        public int Id { get; set; }
        public int UiPageId { get; set; }
        public int Level { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public UiPage UiPage { get; set; }
        public ICollection<BreadCrumbLocalize> BreadCrumbLocalize { get; set; }
    }
}
