using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class PlaceOwnershipLocalize
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PlaceOwnershipId { get; set; }
        public int LanguageId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime? ModifiedBy { get; set; }
        public DateTime? DeletedBy { get; set; }

        public PlaceOwnership PlaceOwnership { get; set; }
    }
}
