using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Controllers
{
    public class LandmarksController : Controller
    {
        private readonly AppDbContext _context;

        public LandmarksController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allLandmarks = await _context.Landmarks.ToListAsync();
            return View();
        }
    }
}
