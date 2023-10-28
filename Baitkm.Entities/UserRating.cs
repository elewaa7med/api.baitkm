using Baitkm.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baitkm.Entities
{
    public class UserRating : EntityBase
    {
        public int? UserId { get; set; }
        public int UserRated { get; set; }
        public int? GuestId { get; set; }
        public int Rat { get; set; }

        public virtual User User { get; set; }
        public virtual Guest Guest { get; set; }
    }
}