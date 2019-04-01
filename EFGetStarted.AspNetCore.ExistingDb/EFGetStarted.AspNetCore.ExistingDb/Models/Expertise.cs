using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Expertise
    {
        public Expertise()
        {
            DoctorExpertise = new HashSet<DoctorExpertise>();
            ExpertiseLocalize = new HashSet<ExpertiseLocalize>();
            InverseParrent = new HashSet<Expertise>();
        }

        public int Id { get; set; }
        public int? ParrentId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public Expertise Parrent { get; set; }
        public ICollection<DoctorExpertise> DoctorExpertise { get; set; }
        public ICollection<ExpertiseLocalize> ExpertiseLocalize { get; set; }
        public ICollection<Expertise> InverseParrent { get; set; }
    }
}
