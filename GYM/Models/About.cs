using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class About : BaseEntity
    {
        public string Title { get; set; }
        public string Heading { get; set; }
        public string ShortDesc { get; set; }
        public string FullDesc { get; set; }
        public string AboutPhoto { get; set; }

    }
}
