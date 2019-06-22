using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SomeSOM.Models;

namespace SomeSOM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Map map = new Map(5, 5);
            map.InitializeNodeWeights();
            HomeViewModel model = new HomeViewModel(map);
            

            return View(model);
        }

       
    }
}
