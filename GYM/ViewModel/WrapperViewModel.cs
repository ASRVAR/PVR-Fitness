using GYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.ViewModel
{
    public class WrapperViewModel
    {   
        public IEnumerable<Banner> Banner { get; set; }
        public IEnumerable<About> About { get; set; }
        public IEnumerable<Price> Price { get; set; }
        public IEnumerable<Blog> Blog { get; set; }
        public IEnumerable<Trainers> Trainers { get; set; }
    }
}
