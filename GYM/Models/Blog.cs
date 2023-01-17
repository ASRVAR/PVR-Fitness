using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class Blog : BaseEntity
    {
        public string BlogType { get; set; }
        public string BlogTitle { get; set; }
        public string Heading { get; set; }
        public string WritterName { get; set; }
        public string Description { get; set; }
        public string PhotoTitle { get; set; }
        public string BlogPhoto { get; set; }
    }
}
