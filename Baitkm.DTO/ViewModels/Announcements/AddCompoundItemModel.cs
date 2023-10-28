using Baitkm.DTO.ViewModels.Bases;
using Baitkm.Enums;
using Baitkm.Enums.Attachments;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Baitkm.DTO.ViewModels.Announcements
{
    public class AddCompoundItemModel : IViewModel
    {
        public int id { get; set; }
        public decimal Price { get; set; }
        public decimal? Area { get; set; }
        public FurnishingStatus? FurnishingStatus { get; set; }// can be null every time
        public int? Floor { get; set; }
        public int? NumberOfFloors { get; set; }
        public List<AnnouncementFeaturesType> Features { get; set; }
        public int? SittingCount { get; set; } // can be null every time
        public int? BedroomCount { get; set; }
        public int? BathroomCount { get; set; }
        public AnnouncementRentType? AnnouncementRentType { get; set; }
        public int? AnnouncementId { get; set; }
    }

}