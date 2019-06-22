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
            Map map = new Map(25);
            SOM som = new SOM(map, 20);

            map.InitializeNodeWeights();
            HomeViewModel model = new HomeViewModel(som);
            return View(model);
        }

        [HttpPost]
        public ActionResult Iterate(SOM som)
        {
            som.Map.Grid[0,0] = new SOMColor(0, 0, 0);
            return View(som);
        }
    }
}
