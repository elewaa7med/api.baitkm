using Baitkm.DTO.ViewModels.Helpers.Paging;
using Baitkm.Enums;
using Baitkm.Enums.Attachments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baitkm.DTO.ViewModels.Announcements
{
    public class MobileNearByModel : PagingRequestModel
    {
        public AnnouncementEstateType? AnnouncementEstateType { get; set; }
        public AnnouncementResidentialType? AnnouncementResidentialType { get; set; }
        public CommercialType? CommercialType { get; set; }
        public LandType? LandType { get; set; }
    }
}
