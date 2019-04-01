using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class HealthService
    {
        public HealthService()
        {
            HealthServiceLocalize = new HashSet<HealthServiceLocalize>();
            PlaceHealthService = new HashSet<PlaceHealthService>();
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

        public ICollection<HealthServiceLocalize> HealthServiceLocalize { get; set; }
        public ICollection<PlaceHealthService> PlaceHealthService { get; set; }
    }
}
