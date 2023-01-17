using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class Banner : BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter Heading")]
        public string Heading { get; set; }

        [Required(ErrorMessage = "Please choose Banner image")]
        public string BannerPhotos { get; set; }

        internal static object FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        internal static Task FindAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
