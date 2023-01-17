using GYM.DataModel;
using GYM.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Controllers
{
    public class PriceController : Controller
    {
        public readonly dataContext _context;
        public PriceController(dataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Get Action
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var priceList = _context.Price.ToList();
            return View(priceList);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        public IActionResult Details(int Id)
        {
            var PriceDetails = _context.Price.Where(x => x.Id == Id).FirstOrDefault();
            return View(PriceDetails);
        }
        public IActionResult Edit(int Id)
        {
            var PriceDetails = _context.Price.Where(x => x.Id == Id).FirstOrDefault();
            return View(PriceDetails);
        }
        public IActionResult Delete(int Id)
        {
            var PriceDetails = _context.Price.Where(x => x.Id == Id).FirstOrDefault();
            return View(PriceDetails);
        }

        /// <summary>
        /// Post Action
        /// </summary>
        /// <param></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Create(Price prc)
        {
            _context.Price.Add(prc);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Price prc)
        {
            var priceEdit = _context.Price.Update(prc);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Price prc)
        {
            var pricedelete = _context.Price.Remove(prc);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
