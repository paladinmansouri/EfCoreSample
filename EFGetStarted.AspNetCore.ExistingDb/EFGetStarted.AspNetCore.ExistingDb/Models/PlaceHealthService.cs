using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class PlaceHealthService
    {
        public PlaceHealthService()
        {
            SubPlaceHealthService = new HashSet<SubPlaceHealthService>();
        }

        public int Id { get; set; }
        public int PlaceId { get; set; }
        public int HealthServiceId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public HealthService HealthService { get; set; }
        public Place Place { get; set; }
        public ICollection<SubPlaceHealthService> SubPlaceHealthService { get; set; }
    }
}
