using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Data;
using Mountain_Trips_and_Landmarks.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Controllers
{
    public class LandmarksController : Controller
    {
        private readonly ILandmarksService _service;

       public LandmarksController(ILandmarksService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allLandmarks = await _service.GetAllAsync();
            return View(allLandmarks);
        }
    }
}
