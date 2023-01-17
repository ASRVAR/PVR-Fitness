using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class Trainers : BaseEntity
    {
        public string Name { get; set; }
        public string TrainerType { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Behance { get; set; }
        public string Description { get; set; }
        public string ProfilePhoto { get; set; }
    }
}
