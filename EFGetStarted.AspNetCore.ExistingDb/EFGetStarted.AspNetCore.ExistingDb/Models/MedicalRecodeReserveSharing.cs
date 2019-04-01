using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class MedicalRecodeReserveSharing
    {
        public int Id { get; set; }
        public int MedicalRecordReserveId { get; set; }
        public int MedicalRecodeSharingId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public MedicalRecodeSharing MedicalRecodeSharing { get; set; }
        public MedicalRecord MedicalRecordReserve { get; set; }
    }
}
