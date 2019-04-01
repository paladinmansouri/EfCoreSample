using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class GeneralContentType
    {
        public GeneralContentType()
        {
            GeneralContent = new HashSet<GeneralContent>();
            GeneralContentTypeLocalize = new HashSet<GeneralContentTypeLocalize>();
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

        public ICollection<GeneralContent> GeneralContent { get; set; }
        public ICollection<GeneralContentTypeLocalize> GeneralContentTypeLocalize { get; set; }
    }
}
