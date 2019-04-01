using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class PatientPlaceEvaluation
    {
        public PatientPlaceEvaluation()
        {
            PatientPlaceEvaluationCriteria = new HashSet<PatientPlaceEvaluationCriteria>();
        }

        public int Id { get; set; }
        public int ReserveId { get; set; }
        public int PaientId { get; set; }
        public int PlaceId { get; set; }
        public int Rank { get; set; }
        public string Descripton { get; set; }
        public string ThankNote { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Patient Paient { get; set; }
        public Place Place { get; set; }
        public Reserve Reserve { get; set; }
        public ICollection<PatientPlaceEvaluationCriteria> PatientPlaceEvaluationCriteria { get; set; }
    }
}
