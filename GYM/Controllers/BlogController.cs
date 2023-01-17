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
    public class BlogController : Controller
    {
        private readonly dataContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public BlogController(dataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var _getBlogs = _context.Blog.ToList();
            return View(_getBlogs);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(int Id)
        {
            var _detailsBlog = _context.Blog.Where(x => x.Id == Id).FirstOrDefault();
            return View(_detailsBlog);
        }
        public IActionResult Delete(int Id)
        {
            var _deleteBlog = _context.Blog.Where(x => x.Id == Id).FirstOrDefault();
            return View(_deleteBlog);
        }
        [HttpPost]
        public IActionResult Create(BlogViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);
                Blog blog = new Blog
                {
                    BlogType = model.BlogType,
                    BlogTitle = model.BlogTitle,
                    Heading = model.Heading,
                    WritterName = model.WritterName,
                    Description = model.Description,
                    PhotoTitle = model.PhotoTitle,
                    BlogPhoto = uniqueFileName,
                    CreateDate = model.CreateDate,
                    IsActive=model.IsActive,
                };

                _context.Blog.Add(blog);
                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Blog blog)
        {
            _context.Blog.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        private string UploadedFile(BlogViewModel model)
        {
            string uniqueFileName = null;

            if (model.BlogPhoto != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "BlogImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.BlogPhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.BlogPhoto.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
