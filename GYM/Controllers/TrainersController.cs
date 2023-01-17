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
    public class TrainersController : Controller
    {
        public readonly dataContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public  TrainersController(dataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        } 
        public IActionResult Index()
        {
            var _trainerData = _context.Trainers.ToList();
            return View(_trainerData);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(int? Id)
        {
            if(Id == null)
            {
                return View("./Error");
            }
            var _trainersDetails = _context.Trainers.Where(x => x.Id == Id).FirstOrDefault();
            return View(_trainersDetails);
        }
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return View("./Error");
            }
            var _trainersDelete = _context.Trainers.Where(x => x.Id == Id).FirstOrDefault();
            return View(_trainersDelete);
        }
        [HttpPost]
        public IActionResult Create(TrainersViewModel model)
        {

            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);
                Trainers tnr = new Trainers
                {
                    Name = model.Name,
                    TrainerType = model.TrainerType,
                    Facebook = model.Facebook,
                    Twitter = model.Twitter,
                    Behance = model.Behance,
                    Description = model.Description,
                    ProfilePhoto = uniqueFileName,
                    CreateDate=model.CreateDate,
                    IsActive=model.IsActive,
                };

                _context.Trainers.Add(tnr);
                _context.SaveChanges();

            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Trainers trn)
        {
            _context.Trainers.Remove(trn);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        private string UploadedFile(TrainersViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProfilePhoto != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "TrainersImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfilePhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfilePhoto.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}
