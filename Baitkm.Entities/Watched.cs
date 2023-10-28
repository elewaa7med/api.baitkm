using Baitkm.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baitkm.Entities
{
    public class Watched : EntityBase
    {
        public int AnnouncementId { get; set; }
        public int? UserId { get; set; }
        public int? GuestId { get; set; }

        public virtual Announcement Announcement { get; set; }
        public virtual User User { get; set; }
        public virtual Guest Guest { get; set; }

    }
}
