using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class User
    {
        public User()
        {
            UserBankCard = new HashSet<UserBankCard>();
            UserPermission = new HashSet<UserPermission>();
        }

        public int Id { get; set; }
        public int UserGroupId { get; set; }
        public long UserOwnerId { get; set; }
        public bool IsLegal { get; set; }
        public string NationalCode { get; set; }
        public string MobileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? SexId { get; set; }
        public int? CityId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Avatar { get; set; }
        public bool IsLock { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public City City { get; set; }
        public Sex Sex { get; set; }
        public UserGroup UserGroup { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Secretary Secretary { get; set; }
        public ICollection<UserBankCard> UserBankCard { get; set; }
        public ICollection<UserPermission> UserPermission { get; set; }
    }
}
