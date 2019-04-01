using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class DoctorSubPlace
    {
        public DoctorSubPlace()
        {
            SecretarySubPlace = new HashSet<SecretarySubPlace>();
            ShiftWork = new HashSet<ShiftWork>();
        }

        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int SubPlaceId { get; set; }
        public int SubPlaceHealthServiceId { get; set; }
        public decimal? PercentageReserve { get; set; }
        public int VisitCost { get; set; }
        public int ReserveCost { get; set; }
        public bool IsDiscount { get; set; }
        public int? DiscountPercent { get; set; }
        public TimeSpan VisitTime { get; set; }
        public bool IsMandatoryPayment { get; set; }
        public bool IsOnlinePayment { get; set; }
        public int? StratSaleDay { get; set; }
        public int? EndSaleDay { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Doctor Doctor { get; set; }
        public SubPlace SubPlace { get; set; }
        public SubPlaceHealthService SubPlaceHealthService { get; set; }
        public ICollection<SecretarySubPlace> SecretarySubPlace { get; set; }
        public ICollection<ShiftWork> ShiftWork { get; set; }
    }
}
