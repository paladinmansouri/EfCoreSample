using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class MedicalRecordReserveAdvice
    {
        public int Id { get; set; }
        public int MedicalRecordReserveId { get; set; }
        public int MedicalRecodeAdviceId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public MedicalRecodeAdvice MedicalRecodeAdvice { get; set; }
        public MedicalRecord MedicalRecordReserve { get; set; }
    }
}
