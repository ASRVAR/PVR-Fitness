using GYM.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.ViewModel
{
    public class BannerViewModel : BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter Heading")]
        public string Heading { get; set; }

        [Required(ErrorMessage = "Please choose Banner image")]
        [Display(Name = "Banner Image")]
        public IFormFile BannerPhotos { get; set; }
    }
}
