using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class MedicalRecordSicknessTag
    {
        public int Id { get; set; }
        public int? MedicalRecodeId { get; set; }
        public int? SicknessTag { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public MedicalRecord MedicalRecode { get; set; }
        public SicknessTag SicknessTagNavigation { get; set; }
    }
}
