﻿using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            User = new HashSet<User>();
            UserGroupLocalize = new HashSet<UserGroupLocalize>();
            UserGroupPermission = new HashSet<UserGroupPermission>();
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public ICollection<User> User { get; set; }
        public ICollection<UserGroupLocalize> UserGroupLocalize { get; set; }
        public ICollection<UserGroupPermission> UserGroupPermission { get; set; }
    }
}