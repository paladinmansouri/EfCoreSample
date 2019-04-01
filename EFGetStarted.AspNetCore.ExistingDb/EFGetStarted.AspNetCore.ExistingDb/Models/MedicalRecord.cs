using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class MedicalRecord
    {
        public MedicalRecord()
        {
            MedicalMedicine = new HashSet<MedicalMedicine>();
            MedicalRecodeReserveSharing = new HashSet<MedicalRecodeReserveSharing>();
            MedicalRecordFile = new HashSet<MedicalRecordFile>();
            MedicalRecordReserveAdvice = new HashSet<MedicalRecordReserveAdvice>();
            MedicalRecordSicknessTag = new HashSet<MedicalRecordSicknessTag>();
        }

        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int ReserverId { get; set; }
        public bool IsPatientAccess { get; set; }
        public string DiseaseDescription { get; set; }
        public string Treatment { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Reserve Reserver { get; set; }
        public ICollection<MedicalMedicine> MedicalMedicine { get; set; }
        public ICollection<MedicalRecodeReserveSharing> MedicalRecodeReserveSharing { get; set; }
        public ICollection<MedicalRecordFile> MedicalRecordFile { get; set; }
        public ICollection<MedicalRecordReserveAdvice> MedicalRecordReserveAdvice { get; set; }
        public ICollection<MedicalRecordSicknessTag> MedicalRecordSicknessTag { get; set; }
    }
}
