using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class Place
    {
        public Place()
        {
            LegalContract = new HashSet<LegalContract>();
            PatientPlaceEvaluation = new HashSet<PatientPlaceEvaluation>();
            PlaceContact = new HashSet<PlaceContact>();
            PlaceFile = new HashSet<PlaceFile>();
            PlaceHealthService = new HashSet<PlaceHealthService>();
            PlaceInsurance = new HashSet<PlaceInsurance>();
            PlaceLocalize = new HashSet<PlaceLocalize>();
            SubPlace = new HashSet<SubPlace>();
        }

        public int Id { get; set; }
        public int PlaceOwnershipId { get; set; }
        public int PlaceTypeId { get; set; }
        public string PlaceAddress { get; set; }
        public int CityId { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public bool IsActive { get; set; }
        public bool IsDel { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }

        public PlaceOwnership PlaceOwnership { get; set; }
        public PlaceType PlaceType { get; set; }
        public ICollection<LegalContract> LegalContract { get; set; }
        public ICollection<PatientPlaceEvaluation> PatientPlaceEvaluation { get; set; }
        public ICollection<PlaceContact> PlaceContact { get; set; }
        public ICollection<PlaceFile> PlaceFile { get; set; }
        public ICollection<PlaceHealthService> PlaceHealthService { get; set; }
        public ICollection<PlaceInsurance> PlaceInsurance { get; set; }
        public ICollection<PlaceLocalize> PlaceLocalize { get; set; }
        public ICollection<SubPlace> SubPlace { get; set; }
    }
}
