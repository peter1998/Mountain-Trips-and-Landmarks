using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Controllers
{
    public class TracksController : Controller
    {
        private readonly AppDbContext _context;

        public TracksController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allTrackss = await _context.Tracks.ToListAsync();
            return View();
        }
    }
}
