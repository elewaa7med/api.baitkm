using Baitkm.DTO.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Baitkm.DTO.ViewModels.Persons.Users
{
    public class AddUserRatingModel : IViewModel
    {
        [Range(1, 5)]
        public int Rating { get; set; }
        public int UserId { get; set; }
    }
}
