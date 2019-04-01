using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class NewsLocalize
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string ShortBody { get; set; }
        public int LanguageId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Language Language { get; set; }
        public News News { get; set; }
    }
}
