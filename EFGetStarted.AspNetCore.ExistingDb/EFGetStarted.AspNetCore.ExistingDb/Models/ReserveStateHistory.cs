using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class ReserveStateHistory
    {
        public int Id { get; set; }
        public int ReserveId { get; set; }
        public int OldReserveStateId { get; set; }
        public int CurrentReserveStateId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ReserveState CurrentReserveState { get; set; }
        public ReserveState OldReserveState { get; set; }
        public Reserve Reserve { get; set; }
    }
}
