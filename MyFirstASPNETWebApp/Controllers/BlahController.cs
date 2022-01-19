using Microsoft.AspNetCore.Mvc;
using MyFirstASPNETWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebApp.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //the view that were accessing the name 
        [HttpGet]
        public IActionResult GradeWeights()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeWeights(GradeWeightsModel model)
        {
            return View();
        }
    }
}
