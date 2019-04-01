using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class PlaceOwnership
    {
        public PlaceOwnership()
        {
            Place = new HashSet<Place>();
            PlaceOwnershipLocalize = new HashSet<PlaceOwnershipLocalize>();
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime? ModifiedBy { get; set; }
        public DateTime? DeletedBy { get; set; }

        public ICollection<Place> Place { get; set; }
        public ICollection<PlaceOwnershipLocalize> PlaceOwnershipLocalize { get; set; }
    }
}
