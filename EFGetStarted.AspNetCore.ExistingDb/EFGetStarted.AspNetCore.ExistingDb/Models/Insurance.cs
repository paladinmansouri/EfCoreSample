using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Insurance
    {
        public Insurance()
        {
            InsuranceLocalize = new HashSet<InsuranceLocalize>();
            PatientInsurance = new HashSet<Patient>();
            PatientSupplementaryInsurance = new HashSet<Patient>();
            PlaceInsurance = new HashSet<PlaceInsurance>();
        }

        public int Id { get; set; }
        public bool IsSupplementaryInsurance { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<InsuranceLocalize> InsuranceLocalize { get; set; }
        public ICollection<Patient> PatientInsurance { get; set; }
        public ICollection<Patient> PatientSupplementaryInsurance { get; set; }
        public ICollection<PlaceInsurance> PlaceInsurance { get; set; }
    }
}
