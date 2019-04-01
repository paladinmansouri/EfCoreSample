using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class MedicalMedicine
    {
        public int Id { get; set; }
        public int MedicalRecordId { get; set; }
        public int Medicine { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public MedicalRecord MedicalRecord { get; set; }
        public Medicine MedicineNavigation { get; set; }
    }
}
