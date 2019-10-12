using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BikingLog.Models;

using System.Threading.Tasks;

namespace BikingLog.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
            
        }

        public ViewResult Trails()
        {
            Trail[] trailArray =
            {

                new Trail {TrailID = 1, Name = "Cumberland Valley Trail", Location="Newville", Miles=21, DifficultyLevel = 4},
                new Trail {TrailID = 2, Name = "Conewago Recreation Trail", Location="Elizabethtown", Miles=5,  DifficultyLevel = 2},
                new Trail {TrailID = 3, Name = "Jonathan Eshenour Memorial Trail", Location="Hummelstown", Miles=13, DifficultyLevel = 3},
                new Trail {TrailID = 4, Name = "Heritage Rail Trail", Location="York", Miles=21,  DifficultyLevel = 4},
                new Trail {TrailID = 5, Name = "Capital Area Greenbelt", Location="Harrisburg", Miles=20, DifficultyLevel = 4},
                new Trail {TrailID = 6, Name = "Lebanon Valley Rail Trail", Location="Lebanon", Miles=12,  DifficultyLevel = 3}

            };

            return View(trailArray);
        }
    }
}
