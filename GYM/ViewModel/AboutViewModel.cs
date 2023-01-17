using GYM.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.ViewModel
{
    public class AboutViewModel: BaseEntity
    {

        [Required(ErrorMessage = "Please Enter Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter Heading")]
        public string Heading { get; set; }
        [Required(ErrorMessage = "Please Enter ShortDesc")]
        public string ShortDesc { get; set; }
        [Required(ErrorMessage = "Please Enter FullDesc")]
        public string FullDesc { get; set; }

        [Required(ErrorMessage = "Please choose About image")]
        [Display(Name = "About Image")]
        public IFormFile AboutPhoto { get; set; }
    }
}
