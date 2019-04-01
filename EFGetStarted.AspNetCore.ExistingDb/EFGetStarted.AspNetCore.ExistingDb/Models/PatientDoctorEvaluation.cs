using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class PatientDoctorEvaluation
    {
        public PatientDoctorEvaluation()
        {
            PatientDoctorEvaluationCriteria = new HashSet<PatientDoctorEvaluationCriteria>();
        }

        public int Id { get; set; }
        public int ReserveId { get; set; }
        public int PaientId { get; set; }
        public int DoctorId { get; set; }
        public int Rank { get; set; }
        public string Descripton { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Doctor Doctor { get; set; }
        public Patient Paient { get; set; }
        public Reserve Reserve { get; set; }
        public ICollection<PatientDoctorEvaluationCriteria> PatientDoctorEvaluationCriteria { get; set; }
    }
}
