using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Calendar
    {
        public Calendar()
        {
            PersonalHoliday = new HashSet<PersonalHoliday>();
            ReserveHistory = new HashSet<ReserveHistory>();
        }

        public int Id { get; set; }
        public string PersianDate { get; set; }
        public DateTime GregorianDate { get; set; }
        public bool IsOfficialHoliday { get; set; }
        public int PersianDayNumberInWeek { get; set; }
        public int GregorianDayNumberInWeek { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<PersonalHoliday> PersonalHoliday { get; set; }
        public ICollection<ReserveHistory> ReserveHistory { get; set; }
    }
}
