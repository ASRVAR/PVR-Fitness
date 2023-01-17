using GYM.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.ViewModel
{
    public class BlogViewModel : BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Blog Type")]
        public string BlogType { get; set; }
        [Required(ErrorMessage = "Please Enter Blog Title")]
        public string BlogTitle { get; set; }
        [Required(ErrorMessage = "Please Enter Heading")]
        public string Heading { get; set; }
        [Required(ErrorMessage = "Please Enter Writter Name")]
        public string WritterName { get; set; }
        [Required(ErrorMessage = "Please Enter Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please Enter Photo Title")]
        public string PhotoTitle { get; set; }
        [Required(ErrorMessage = "Please choose Blog Photo")]
        [Display(Name = "Blog Photo")]
        public IFormFile BlogPhoto { get; set; }
        
    }
}
