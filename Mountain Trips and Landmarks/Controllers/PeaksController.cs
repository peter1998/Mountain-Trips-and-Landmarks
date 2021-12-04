using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Data;
using Mountain_Trips_and_Landmarks.Data.Services;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Controllers
{
    public class PeaksController : Controller
    {
        private readonly IPeakService _service;

        public PeaksController(IPeakService service )
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allPeaks = await _service.GetAllAsync();
            return View(allPeaks);
        }

        //Get: Peaks/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")]Peak peak)
        {
            if(!ModelState.IsValid)
            {
                return View(peak);
            }
            await _service.AddAsync(peak);
            return RedirectToAction(nameof(Index));
        }

        //Get: Peaks/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var peakDetails = await _service.GetByIdAsync(id);

            if (peakDetails == null) return View("Empty");
            return View(peakDetails);
        }
    }
}
