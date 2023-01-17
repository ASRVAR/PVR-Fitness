using GYM.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.ViewModel
{
    public class TrainersViewModel :BaseEntity
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter TrainerType")]
        [Display(Name = "Trainer Type")]
        public string TrainerType { get; set; }
        [Required(ErrorMessage = "Please Enter Facebook")]
        [Display(Name = "Facebook Link")]
        public string Facebook { get; set; }
        [Required(ErrorMessage = "Please Enter Twitter")]
        [Display(Name = "Twitter Link")]
        public string Twitter { get; set; }
        [Required(ErrorMessage = "Please Enter Behance")]
        public string Behance { get; set; }
        [Required(ErrorMessage = "Please Enter Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please choose ProfilePhoto image")]
        [Display(Name = "Profile Photo")]
        public IFormFile ProfilePhoto { get; set; }
      
    }
}
