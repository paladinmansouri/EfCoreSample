using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class UserAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string MobileNumberPreCode { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberPreCode { get; set; }
        public string PostalCode { get; set; }
        public string FullAddress { get; set; }
        public string Langtiude { get; set; }
        public string Latitude { get; set; }
        public int CityId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public City City { get; set; }
    }
}
