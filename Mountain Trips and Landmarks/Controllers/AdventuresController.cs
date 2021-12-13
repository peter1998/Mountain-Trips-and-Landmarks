using Microsoft.AspNetCore.Mvc;
using Mountain_Trips_and_Landmarks.Data.Adventure;
using Mountain_Trips_and_Landmarks.Data.Services;
using Mountain_Trips_and_Landmarks.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Controllers
{
    public class AdventuresController : Controller
    {
        private readonly ITracksService _tracksService;
        private readonly SelectorAdventure _selectorAdventure;

        public AdventuresController(ITracksService tracksService, SelectorAdventure selectorAdventure)
        {
            _tracksService = tracksService;
            _selectorAdventure = selectorAdventure;
        }

        public IActionResult Index()
        {
            var items = _selectorAdventure.GetSelectorAdventureItems();
            _selectorAdventure.SelectorAdventureItems = items;

            var response = new SelectorAdventureVM()
            {
                SelectorAdventure = _selectorAdventure,
                SelectorAdventureTotal = _selectorAdventure.GetSelectorAdventureItemsTotalDate()
            };
            return View(response);
        }

        public async Task<RedirectToActionResult> AddToAdventures(int id)
        {
            var item = await _tracksService.GetTrackByIdAsync(id);

            if (item != null)
            {
                _selectorAdventure.addItemtoAdventure(item);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
