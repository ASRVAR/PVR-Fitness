using GYM.DataModel;
using iText.Html2pdf;
using iText.IO.Source;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Controllers
{
    public class SignUpViewController : Controller
    {
        private readonly dataContext _context;
        public SignUpViewController(dataContext context) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
          // var _signupDetails=_context.Signup.ToList();
            return View(this._context.Signup.Take(10).ToList());
        }
    }
}
