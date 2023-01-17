using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class Signup : BaseEntity
    {
        public string Name { get; set; }
        public string EmailId { get; set; }
    }
}
