using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Patient
    {
        public Patient()
        {
            MedicalRecodeAdvice = new HashSet<MedicalRecodeAdvice>();
            MedicalRecord = new HashSet<MedicalRecord>();
            PatientDoctorEvaluation = new HashSet<PatientDoctorEvaluation>();
            PatientPlaceEvaluation = new HashSet<PatientPlaceEvaluation>();
            PatientSecretaryEvaluation = new HashSet<PatientSecretaryEvaluation>();
            PatientWallet = new HashSet<PatientWallet>();
            Reserve = new HashSet<Reserve>();
        }

        public int UserId { get; set; }
        public int? InsuranceId { get; set; }
        public int? InsuranceNumber { get; set; }
        public bool IsSupplementaryInsurance { get; set; }
        public int? SupplementaryInsuranceId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Insurance Insurance { get; set; }
        public Insurance SupplementaryInsurance { get; set; }
        public User User { get; set; }
        public ICollection<MedicalRecodeAdvice> MedicalRecodeAdvice { get; set; }
        public ICollection<MedicalRecord> MedicalRecord { get; set; }
        public ICollection<PatientDoctorEvaluation> PatientDoctorEvaluation { get; set; }
        public ICollection<PatientPlaceEvaluation> PatientPlaceEvaluation { get; set; }
        public ICollection<PatientSecretaryEvaluation> PatientSecretaryEvaluation { get; set; }
        public ICollection<PatientWallet> PatientWallet { get; set; }
        public ICollection<Reserve> Reserve { get; set; }
    }
}
