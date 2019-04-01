using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class PlaceType
    {
        public PlaceType()
        {
            Place = new HashSet<Place>();
            PlaceTypeLocalize = new HashSet<PlaceTypeLocalize>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? CommissionAmount { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<Place> Place { get; set; }
        public ICollection<PlaceTypeLocalize> PlaceTypeLocalize { get; set; }
    }
}
