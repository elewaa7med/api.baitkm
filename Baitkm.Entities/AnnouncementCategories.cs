using Baitkm.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baitkm.Entities
{
    public class AnnouncementCategories : EntityBase
    {
        public string CategoryNameAr { get; set; }
        public string CategoryNameEn { get; set; }
        public int CategoryId { get; set; }
        public string MasterCategoryName { get; set; }
    }
}
