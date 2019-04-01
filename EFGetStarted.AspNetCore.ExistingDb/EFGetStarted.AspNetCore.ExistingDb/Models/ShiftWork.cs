using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class ShiftWork
    {
        public ShiftWork()
        {
            PersonalHoliday = new HashSet<PersonalHoliday>();
            ReserveHistory = new HashSet<ReserveHistory>();
        }

        public int Id { get; set; }
        public int DoctorSubPlaceId { get; set; }
        public int ShiftWorkTypeId { get; set; }
        public int PersianDayNumberInWeek { get; set; }
        public int GregorianNumberInWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public TimeSpan? BlockStratTime { get; set; }
        public TimeSpan? BlockEndTime { get; set; }
        public TimeSpan? StartResponseTime { get; set; }
        public TimeSpan? EndResponseTime { get; set; }
        public bool IsWorkingOfficialHolidays { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public DoctorSubPlace DoctorSubPlace { get; set; }
        public ShiftWorkType ShiftWorkType { get; set; }
        public ICollection<PersonalHoliday> PersonalHoliday { get; set; }
        public ICollection<ReserveHistory> ReserveHistory { get; set; }
    }
}
