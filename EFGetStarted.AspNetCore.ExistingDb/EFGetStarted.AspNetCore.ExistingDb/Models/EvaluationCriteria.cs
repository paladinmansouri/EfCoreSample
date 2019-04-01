using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class EvaluationCriteria
    {
        public EvaluationCriteria()
        {
            EvaluationCriteriaLocalize = new HashSet<EvaluationCriteriaLocalize>();
            PatientDoctorEvaluationCriteria = new HashSet<PatientDoctorEvaluationCriteria>();
            PatientPlaceEvaluationCriteria = new HashSet<PatientPlaceEvaluationCriteria>();
            PatientSecretaryEvaluationCriteria = new HashSet<PatientSecretaryEvaluationCriteria>();
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<EvaluationCriteriaLocalize> EvaluationCriteriaLocalize { get; set; }
        public ICollection<PatientDoctorEvaluationCriteria> PatientDoctorEvaluationCriteria { get; set; }
        public ICollection<PatientPlaceEvaluationCriteria> PatientPlaceEvaluationCriteria { get; set; }
        public ICollection<PatientSecretaryEvaluationCriteria> PatientSecretaryEvaluationCriteria { get; set; }
    }
}
