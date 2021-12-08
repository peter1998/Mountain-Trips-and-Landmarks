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

        //Get: landmarks/details/1
        public async Task<IActionResult> Details(int id)
        {
            var landmarksDetails = await _service.GetByIdAsync(id);
            if (landmarksDetails ==null)
            {
                return View("NotFound");
            }
            else
            {
                return View(landmarksDetails);
            }
        }

        //Get: landmarks/create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("LandmarkPictureURL,Name,Country,Description")]Landmark landmark)
        {
            if (!ModelState.IsValid)
            {
                return View(landmark);
            }
            else
            {
                await _service.AddAsync(landmark);
                return RedirectToAction(nameof(Index));
            }
        }

        //Get: landmarks/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var landmarkDetails = await _service.GetByIdAsync(id);

            if (landmarkDetails==null)
            {
                return View("NotFound");
            }
            else
            {

            return View(landmarkDetails);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("LandmarkPictureURL,Name,Country,Description")] Landmark landmark)
        {

            landmark.Id = id;
            if (!ModelState.IsValid)
            {
                return View(landmark);
            }
            else if (id == landmark.Id)
            {
                await _service.UpdateAsync(id, landmark);
                return RedirectToAction(nameof(Index));
            }
            return View(landmark);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var landmarkDetails = await _service.GetByIdAsync(id);

            if (landmarkDetails == null) return View("NotFound");
            return View(landmarkDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landmarkDetails = await _service.GetByIdAsync(id);

            if (landmarkDetails == null)
            {
                return View("NotFound");
            }


            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
