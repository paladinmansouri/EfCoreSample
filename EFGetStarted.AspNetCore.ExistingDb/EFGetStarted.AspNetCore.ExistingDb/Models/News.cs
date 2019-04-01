using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class News
    {
        public News()
        {
            NewsHashTag = new HashSet<NewsHashTag>();
            NewsLocalize = new HashSet<NewsLocalize>();
            NewsTag = new HashSet<NewsTag>();
        }

        public int Id { get; set; }
        public int NewsCategoryId { get; set; }
        public Guid ImageId { get; set; }
        public bool IsSpecial { get; set; }
        public bool IsSlider { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public NewsCategory NewsCategory { get; set; }
        public ICollection<NewsHashTag> NewsHashTag { get; set; }
        public ICollection<NewsLocalize> NewsLocalize { get; set; }
        public ICollection<NewsTag> NewsTag { get; set; }
    }
}
