using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class SecretarySubPlace
    {
        public int Id { get; set; }
        public int SecretaryId { get; set; }
        public int DoctorSubPlaceId { get; set; }
        public string ResponseTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public DoctorSubPlace DoctorSubPlace { get; set; }
        public Secretary Secretary { get; set; }
    }
}
