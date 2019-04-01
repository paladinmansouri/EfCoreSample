using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Secretary
    {
        public Secretary()
        {
            PatientSecretaryEvaluation = new HashSet<PatientSecretaryEvaluation>();
            SecretarySubPlace = new HashSet<SecretarySubPlace>();
        }

        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public User User { get; set; }
        public ICollection<PatientSecretaryEvaluation> PatientSecretaryEvaluation { get; set; }
        public ICollection<SecretarySubPlace> SecretarySubPlace { get; set; }
    }
}
