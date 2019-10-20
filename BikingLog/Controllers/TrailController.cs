using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BikingLog.Models;

namespace BikingLog.Controllers
{
    public class TrailController : Controller
    {
        private ITrailRepository repository; 

        public TrailController(ITrailRepository repo)
        {
            repository = repo;
        }

        public ViewResult Trails() => View(repository.Trails);
    }
}