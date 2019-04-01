using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class MedicalRecodeAdvice
    {
        public MedicalRecodeAdvice()
        {
            MedicalRecordReserveAdvice = new HashSet<MedicalRecordReserveAdvice>();
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int FromDoctorId { get; set; }
        public int ToDoctorId { get; set; }
        public string AdviceDescriotion { get; set; }
        public string DoctorOpinion { get; set; }
        public string OpinionFileName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Doctor FromDoctor { get; set; }
        public Patient Patient { get; set; }
        public Doctor ToDoctor { get; set; }
        public ICollection<MedicalRecordReserveAdvice> MedicalRecordReserveAdvice { get; set; }
    }
}
