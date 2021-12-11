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
    public class MountainsController : Controller
    {
        private readonly IMountainsService _service;

        public MountainsController(IMountainsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMountains = await _service.GetAllAsync();
            return View(allMountains);
        }

        //Get: Mountains/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("MountainPictureURL,Name,TrekkingTime,Description")]Mountain mountain)
        {
            if (!ModelState.IsValid)
            {
                return View(mountain);
            }
                await _service.AddAsync(mountain);
                return RedirectToAction(nameof(Index));
            
        }

        //Get:Mountai/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var mountainDetails = await _service.GetByIdAsync(id);

            if (mountainDetails == null) return View("NotFound");
            return View(mountainDetails);

        }

        //Get: Mountains/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var mountainDetails = await _service.GetByIdAsync(id);

            if (mountainDetails == null) return View("NotFound");
            return View(mountainDetails);
        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit(int id, [Bind("MountainPictureURL,Name,TrekkingTime,Description")] Mountain mountain)
        {
            var mountainDetails = await _service.GetByIdAsync(id);

            if (!ModelState.IsValid)
            {
                return View(mountain);
            }

            await _service.UpdateAsync(id, mountain);

            return RedirectToAction(nameof(Index));
        }

        //Get: Peaks/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var mountainDetails = await _service.GetByIdAsync(id);

            if (mountainDetails == null) return View("NotFound");
            return View(mountainDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mountainDetails = await _service.GetMountainByIdAsync(id);

            if (mountainDetails == null)
            {
                return View("NotFound");
            }

            //mountainDetails.WHAT.REMOVEALL(x=> true); TOO MANY
            mountainDetails.Tracks_Mountains.RemoveAll(x => true);
            mountainDetails.Peaks_Mountains.RemoveAll(x => true);

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
