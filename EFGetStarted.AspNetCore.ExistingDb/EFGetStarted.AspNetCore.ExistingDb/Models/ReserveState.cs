using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class ReserveState
    {
        public ReserveState()
        {
            ReserveHistory = new HashSet<ReserveHistory>();
            ReserveStateHistoryCurrentReserveState = new HashSet<ReserveStateHistory>();
            ReserveStateHistoryOldReserveState = new HashSet<ReserveStateHistory>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<ReserveHistory> ReserveHistory { get; set; }
        public ICollection<ReserveStateHistory> ReserveStateHistoryCurrentReserveState { get; set; }
        public ICollection<ReserveStateHistory> ReserveStateHistoryOldReserveState { get; set; }
    }
}
