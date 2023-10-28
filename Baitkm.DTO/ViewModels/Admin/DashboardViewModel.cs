﻿using Baitkm.DTO.ViewModels.Announcements;
using Baitkm.DTO.ViewModels.Bases;
using Baitkm.DTO.ViewModels.Persons.Users.CommonModels;
using System.Collections.Generic;

namespace Baitkm.DTO.ViewModels.Admin
{
    public class DashboardViewModel : IViewModel
    {
        public int ActiveAnnouncementCount { get; set; }
        public int FeaturedAnnouncementCount { get; set; }
        public int RejectedAnnouncements { get; set; }
        public int ExpiredAnnouncements { get; set; }
        public int IsDraftAnnouncements { get; set; }
        public int UnreadSupportMessagesCount { get; set; }
        public int AndroidCount { get; set; }
        public int IosCount { get; set; }
        public int WebCount { get; set; }
        public int UserCount { get; set; }
        public int UserCreateAnnouncemtsCount { get; set; }
    }
}
