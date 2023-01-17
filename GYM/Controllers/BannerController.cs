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
    public class BannerController : Controller
    {
        public readonly dataContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public BannerController(dataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {           
            var bannerList = _context.Banner.ToList();
            return View(bannerList);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(int Id)
        {
            if(Id == null)
            {
                return NotFound();
            }
            var bannerDetails = _context.Banner.Where(x => x.Id == Id).FirstOrDefault();
            return View(bannerDetails);
        }
        public IActionResult Edit(int Id)
        {
            var bannerDetails = _context.Banner.Where(x => x.Id == Id).FirstOrDefault();
            return View(bannerDetails);
        }
        public IActionResult Delete(int Id)
        {
            var bannerDetails = _context.Banner.Where(x => x.Id == Id).FirstOrDefault();
            return View(bannerDetails);
        }

        [HttpPost]
        public IActionResult Create(BannerViewModel model)
        {

            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);
                Banner bnr = new Banner
                {
                    Title = model.Title,
                    Heading = model.Heading,
                    BannerPhotos = uniqueFileName,
                };

                _context.Banner.Add(bnr);
                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(BannerViewModel model)
        {
            string uniqueFileName = UploadedFile(model);
            Banner bnr = new Banner
            {
                Title = model.Title,
                Heading = model.Heading,
                BannerPhotos = uniqueFileName,
                ModifiedDate=DateTime.Now,
            };

            _context.Banner.Update(bnr);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Banner model)
        {
            _context.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        private string UploadedFile(BannerViewModel model)
        {
            string uniqueFileName = null;

            if (model.BannerPhotos != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "BannerImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.BannerPhotos.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.BannerPhotos.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}

