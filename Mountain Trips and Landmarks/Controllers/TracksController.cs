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
            var allTracks = await _service.GetAllTracksAsync();

            return View(allTracks);
        }
        public async Task<IActionResult> Filter(string searchString)
        {
            var allTracks = await _service.GetAllTracksAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredReslt = allTracks.Where(n => n.StartingPoint.Contains(searchString) 
                || n.EndPoint.Contains(searchString)).ToList();
                return View("Index", filteredReslt);
            }

            return View("Index", allTracks);
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

        //Get: Tracks/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var trackDetails = await _service.GetTrackByIdAsync(id);
            if (trackDetails ==null) return View("NotFound");
            
           
                var respone = new NewTrackVm()
                {

                    StartingPoint = trackDetails.StartingPoint,
                    EndPoint = trackDetails.EndPoint,
                    Highlights = trackDetails.Highlights,
                    StartDate = trackDetails.StartDate,
                    EndDate = trackDetails.EndDate,
                    TrackCategory = trackDetails.TrackCategory,
                    TrackCateogryURL = trackDetails.TrackCateogryURL,
                    PeaksIds = trackDetails.Tracks_Peaks.Select(n=>n.PeakId).ToList(),
                    LandmarksIds = trackDetails.Tracks_Landmarks.Select(m=>m.LandmarkId).ToList(),
                    MountainsIds = trackDetails.Tracks_Mountains.Select(h=>h.MountainId).ToList()
                };
            
            var trackDropdownsData = await _service.GetNewTrackDropdownsValues();

            ViewBag.Peaks = new SelectList(trackDropdownsData.Peaks, "Id", "Name");
            ViewBag.Mountains = new SelectList(trackDropdownsData.Mountains, "Id", "Name");
            ViewBag.Landmarks = new SelectList(trackDropdownsData.Landmarks, "Id", "Name");

            return View(respone);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewTrackVm track)
        {
            if (id != track.Id)
            {
                return View("NotFound");
            }

            if (!ModelState.IsValid)
            {
                var trackDropdownsData = await _service.GetNewTrackDropdownsValues();

                ViewBag.Peaks = new SelectList(trackDropdownsData.Peaks, "Id", "Name");
                ViewBag.Mountains = new SelectList(trackDropdownsData.Mountains, "Id", "Name");
                ViewBag.Landmarks = new SelectList(trackDropdownsData.Landmarks, "Id", "Name");

                return View(track);
            }

            await _service.UpdateTrackAsync(track);
            return RedirectToAction(nameof(Index));
        }
    }
}
