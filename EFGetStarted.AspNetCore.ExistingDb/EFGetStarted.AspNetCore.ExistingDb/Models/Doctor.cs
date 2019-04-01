using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            DoctorContact = new HashSet<DoctorContact>();
            DoctorDefaultText = new HashSet<DoctorDefaultText>();
            DoctorExpertise = new HashSet<DoctorExpertise>();
            DoctorFile = new HashSet<DoctorFile>();
            DoctorSubPlace = new HashSet<DoctorSubPlace>();
            MedicalRecodeAdviceFromDoctor = new HashSet<MedicalRecodeAdvice>();
            MedicalRecodeAdviceToDoctor = new HashSet<MedicalRecodeAdvice>();
            MedicalRecodeSharingFromDoctor = new HashSet<MedicalRecodeSharing>();
            MedicalRecodeSharingToDoctor = new HashSet<MedicalRecodeSharing>();
            MedicalRecord = new HashSet<MedicalRecord>();
            PatientDoctorEvaluation = new HashSet<PatientDoctorEvaluation>();
            PersonContract = new HashSet<PersonContract>();
        }

        public int UserId { get; set; }
        public string MedicalSystemCode { get; set; }
        public bool? IsMedicalSystemCodeVerified { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public User User { get; set; }
        public PlaceContact PlaceContact { get; set; }
        public ICollection<DoctorContact> DoctorContact { get; set; }
        public ICollection<DoctorDefaultText> DoctorDefaultText { get; set; }
        public ICollection<DoctorExpertise> DoctorExpertise { get; set; }
        public ICollection<DoctorFile> DoctorFile { get; set; }
        public ICollection<DoctorSubPlace> DoctorSubPlace { get; set; }
        public ICollection<MedicalRecodeAdvice> MedicalRecodeAdviceFromDoctor { get; set; }
        public ICollection<MedicalRecodeAdvice> MedicalRecodeAdviceToDoctor { get; set; }
        public ICollection<MedicalRecodeSharing> MedicalRecodeSharingFromDoctor { get; set; }
        public ICollection<MedicalRecodeSharing> MedicalRecodeSharingToDoctor { get; set; }
        public ICollection<MedicalRecord> MedicalRecord { get; set; }
        public ICollection<PatientDoctorEvaluation> PatientDoctorEvaluation { get; set; }
        public ICollection<PersonContract> PersonContract { get; set; }
    }
}
