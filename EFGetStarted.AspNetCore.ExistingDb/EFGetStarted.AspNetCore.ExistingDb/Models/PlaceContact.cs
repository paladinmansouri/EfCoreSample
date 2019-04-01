using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class PlaceContact
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public int ContactTypeId { get; set; }
        public string ContectValue { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ContactType ContactType { get; set; }
        public Doctor IdNavigation { get; set; }
        public Place Place { get; set; }
    }
}
