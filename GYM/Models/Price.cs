using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class Price : BaseEntity
    {
        public string Heading { get; set; }
        public int Mony { get; set; }
        public string TrainerNumber { get; set; }
        public string Services { get; set; }
        public string Courses { get; set; }
        public string Massages { get; set; }
        public string Aerobics { get; set; }
        


    }
}
