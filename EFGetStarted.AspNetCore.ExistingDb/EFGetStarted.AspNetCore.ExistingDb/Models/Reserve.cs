using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Reserve
    {
        public Reserve()
        {
            FinancialDocument = new HashSet<FinancialDocument>();
            MedicalRecord = new HashSet<MedicalRecord>();
            PatientDoctorEvaluation = new HashSet<PatientDoctorEvaluation>();
            PatientPlaceEvaluation = new HashSet<PatientPlaceEvaluation>();
            PatientSecretaryEvaluation = new HashSet<PatientSecretaryEvaluation>();
            ReschedulingReserve = new HashSet<ReschedulingReserve>();
            ReserveHistory = new HashSet<ReserveHistory>();
            ReserveStateHistory = new HashSet<ReserveStateHistory>();
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public string DiseaseDescription { get; set; }
        public int VisitCost { get; set; }
        public int ReserveCost { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Patient Patient { get; set; }
        public ICollection<FinancialDocument> FinancialDocument { get; set; }
        public ICollection<MedicalRecord> MedicalRecord { get; set; }
        public ICollection<PatientDoctorEvaluation> PatientDoctorEvaluation { get; set; }
        public ICollection<PatientPlaceEvaluation> PatientPlaceEvaluation { get; set; }
        public ICollection<PatientSecretaryEvaluation> PatientSecretaryEvaluation { get; set; }
        public ICollection<ReschedulingReserve> ReschedulingReserve { get; set; }
        public ICollection<ReserveHistory> ReserveHistory { get; set; }
        public ICollection<ReserveStateHistory> ReserveStateHistory { get; set; }
    }
}
