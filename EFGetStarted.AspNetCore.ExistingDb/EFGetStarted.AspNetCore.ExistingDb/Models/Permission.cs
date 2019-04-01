using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Permission
    {
        public Permission()
        {
            PermissionLocalize = new HashSet<PermissionLocalize>();
            UserGroupPermission = new HashSet<UserGroupPermission>();
            UserPermission = new HashSet<UserPermission>();
        }

        public int Id { get; set; }
        public int Parent { get; set; }
        public string PermissionName { get; set; }
        public string ApiAddress { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<PermissionLocalize> PermissionLocalize { get; set; }
        public ICollection<UserGroupPermission> UserGroupPermission { get; set; }
        public ICollection<UserPermission> UserPermission { get; set; }
    }
}
