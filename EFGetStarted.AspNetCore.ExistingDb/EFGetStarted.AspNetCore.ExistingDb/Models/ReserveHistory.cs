using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class ReserveHistory
    {
        public int Id { get; set; }
        public int ReserveId { get; set; }
        public int ShiftWorkId { get; set; }
        public int CalendarId { get; set; }
        public TimeSpan VisitTime { get; set; }
        public int ReserveStateId { get; set; }
        public string DoctorExplanation { get; set; }
        public bool PatientConfirmation { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Calendar Calendar { get; set; }
        public Reserve Reserve { get; set; }
        public ReserveState ReserveState { get; set; }
        public ShiftWork ShiftWork { get; set; }
    }
}
