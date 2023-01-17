using GYM.DataModel;
using GYM.Models;
using GYM.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Controllers
{
    public class AboutController : Controller
    {
        public readonly dataContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AboutController(dataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var aboutData = _context.About.ToList();   
            return View(aboutData);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(int Id)
        {
            var DetailsAbout = _context.About.Where(x => x.Id == Id).FirstOrDefault();
            return View(DetailsAbout);
        }
        public IActionResult Delete(int Id)
        {
            var _deleteAbout = _context.About.Where(x => x.Id == Id).FirstOrDefault();
            return View(_deleteAbout);
        }
        [HttpPost]
        public IActionResult Create(AboutViewModel avm)
        {          
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(avm);
                About ab = new About
                {
                 Title=avm.Title,
                 Heading=avm.Heading,
                 ShortDesc=avm.ShortDesc,
                 FullDesc=avm.FullDesc,
                 AboutPhoto=uniqueFileName,
                 CreateDate=DateTime.Now,
                 IsActive=avm.IsActive,
                };
                _context.About.Add(ab);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(About abt)
        {
            _context.About.Remove(abt);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        private string UploadedFile(AboutViewModel model)
        {
            string uniqueFileName = null;

            if (model.AboutPhoto != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "AboutImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.AboutPhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.AboutPhoto.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
