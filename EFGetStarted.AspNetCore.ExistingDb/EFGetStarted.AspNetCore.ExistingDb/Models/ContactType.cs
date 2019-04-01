using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            ContactTypeLocalize = new HashSet<ContactTypeLocalize>();
            DoctorContact = new HashSet<DoctorContact>();
            PlaceContact = new HashSet<PlaceContact>();
            SubPlaceContact = new HashSet<SubPlaceContact>();
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

        public ICollection<ContactTypeLocalize> ContactTypeLocalize { get; set; }
        public ICollection<DoctorContact> DoctorContact { get; set; }
        public ICollection<PlaceContact> PlaceContact { get; set; }
        public ICollection<SubPlaceContact> SubPlaceContact { get; set; }
    }
}
