using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class SubPlace
    {
        public SubPlace()
        {
            DoctorSubPlace = new HashSet<DoctorSubPlace>();
            InverseSubPlaceParentNavigation = new HashSet<SubPlace>();
            SubPlaceContact = new HashSet<SubPlaceContact>();
            SubPlaceFile = new HashSet<SubPlaceFile>();
            SubPlaceHealthService = new HashSet<SubPlaceHealthService>();
            SubPlaceLocalize = new HashSet<SubPlaceLocalize>();
        }

        public int Id { get; set; }
        public int? SubPlaceParent { get; set; }
        public int PlaceId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Place Place { get; set; }
        public SubPlace SubPlaceParentNavigation { get; set; }
        public ICollection<DoctorSubPlace> DoctorSubPlace { get; set; }
        public ICollection<SubPlace> InverseSubPlaceParentNavigation { get; set; }
        public ICollection<SubPlaceContact> SubPlaceContact { get; set; }
        public ICollection<SubPlaceFile> SubPlaceFile { get; set; }
        public ICollection<SubPlaceHealthService> SubPlaceHealthService { get; set; }
        public ICollection<SubPlaceLocalize> SubPlaceLocalize { get; set; }
    }
}
