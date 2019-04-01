using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class SubPlaceHealthService
    {
        public SubPlaceHealthService()
        {
            DoctorSubPlace = new HashSet<DoctorSubPlace>();
        }

        public int Id { get; set; }
        public int SubPlaceId { get; set; }
        public int PlaceHealthServiceId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public PlaceHealthService PlaceHealthService { get; set; }
        public SubPlace SubPlace { get; set; }
        public ICollection<DoctorSubPlace> DoctorSubPlace { get; set; }
    }
}
