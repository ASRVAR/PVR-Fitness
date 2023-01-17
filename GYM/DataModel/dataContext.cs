using GYM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.DataModel
{
    public class dataContext : DbContext
    {
        public dataContext(DbContextOptions<dataContext> options) : base(options)
        {

        }
        public DbSet<About> About { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Signup> Signup { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
    }

}
