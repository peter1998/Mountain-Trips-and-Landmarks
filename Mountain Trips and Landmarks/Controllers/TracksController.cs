using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class TracksController : Controller
    {
        private readonly ITracksService _service;

        public TracksController(ITracksService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMountains = await _service.GetAllAsync(n => n.Mountain);
            return View(allMountains);
        }

        //Get: Tracks/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var trackDetail = await _service.GetTrackByIdAsync(id);
            return View(trackDetail);
        }

        //Get: Tracks/Create
        public async Task<IActionResult> Create()
        {
            var trackDropdownsData = await _service.GetNewTrackDropdownsValues();

            ViewBag.Peaks = new SelectList(trackDropdownsData.Peaks, "Id", "Name");
            ViewBag.Mountains = new SelectList(trackDropdownsData.Mountains, "Id", "Name");
            ViewBag.Landmarks = new SelectList(trackDropdownsData.Landmarks, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewTrackVm track)
        {
            if (!ModelState.IsValid)
            {
                var trackDropdownsData = await _service.GetNewTrackDropdownsValues();

                ViewBag.Peaks = new SelectList(trackDropdownsData.Peaks, "Id", "Name");
                ViewBag.Mountains = new SelectList(trackDropdownsData.Mountains, "Id", "Name");
                ViewBag.Landmarks = new SelectList(trackDropdownsData.Landmarks, "Id", "Name");

                return View(track);
            }

            await _service.AddNewTrackAsync(track);
            return RedirectToAction(nameof(Index));
        }
    }
}
