using GYM.DataModel;
using GYM.Models;
using GYM.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Controllers
{
    public class HomeController : Controller
    {
        private readonly dataContext _dataContext;

        public HomeController(dataContext context)
        {
            _dataContext = context;
        }

        public IActionResult Index()
        {
            var model = new WrapperViewModel
            {
                Banner = _dataContext.Banner.ToList(),
                About =  _dataContext.About.ToList(),
                Price =  _dataContext.Price.ToList(),
                Trainers = _dataContext.Trainers.ToList(),
                Blog = _dataContext.Blog.OrderByDescending(x => x.Id).Take(5).ToList(),
            };
            return View("Index",model);
        }
        [HttpPost]
        public IActionResult Index(Signup sgp)
        {
            Signup sgn = new Signup()
            {
                Name=sgp.Name,
                EmailId=sgp.EmailId,
                CreateDate= DateTime.Now,
            };
            _dataContext.Signup.Add(sgn);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("blogdetails")]
        public IActionResult Blog(int Id = 0)
        {
            var blogList = _dataContext.Blog.Where(x => x.Id == Id).ToList();
            return View(blogList);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
