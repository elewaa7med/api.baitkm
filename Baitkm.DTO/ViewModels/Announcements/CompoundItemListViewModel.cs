using Baitkm.DTO.ViewModels.Bases;
using Baitkm.DTO.ViewModels.Helpers;
using Baitkm.Enums;
using Baitkm.Enums.Attachments;
using System;
using System.Collections.Generic;

namespace Baitkm.DTO.ViewModels.Announcements
{
    public class CompoundItemListViewModel : IViewModel
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
        public ImageOptimizer Photo { get; set; }
        public ImageOptimizer UserProfilePhoto { get; set; }
        public List<ImageAndVideoOptimizer> Photos { get; set; }
        public bool IsDeleted { get; set; }
        public AnnouncementStatus AnnouncementStatus { get; set; }
    }
}