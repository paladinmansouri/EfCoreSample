using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Sex
    {
        public Sex()
        {
            SexLocalize = new HashSet<SexLocalize>();
            User = new HashSet<User>();
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

        public ICollection<SexLocalize> SexLocalize { get; set; }
        public ICollection<User> User { get; set; }
    }
}
