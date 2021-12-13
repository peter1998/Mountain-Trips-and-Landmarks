using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Adventure
{
    public class SelectorAdventure
    {
        public AppDbContext _context { get; set; }
        public static double days = 0;

        public string SelectorAdventureId { get; set; }
        public List<SelectorAdventureItem> SelectorAdventureItems { get; set; }

        public SelectorAdventure(AppDbContext context)
        {
            _context = context;
        }

        public static SelectorAdventure GetSelectorAdventure(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string adventureId = session.GetString("AdventureId") ?? Guid.NewGuid().ToString();
            session.SetString("AdventureId", adventureId);

            return new SelectorAdventure(context) { SelectorAdventureId = adventureId };
        }


        public void addItemtoAdventure(Track track)
        {
            var selectorAdventureItem = _context.SelectorAdventureItems
                .FirstOrDefault(n => n.Track.Id == track.Id && n.SelectorAdventureId == SelectorAdventureId);

            var peakName = "";
            var landmarkName = "";
            if (track.Tracks_Peaks.Count!=0)
            {
                peakName = track.Tracks_Peaks.FirstOrDefault().Peak.Name;
            }
            

            if (track.Tracks_Landmarks.Count !=0)
            {
                landmarkName = track.Tracks_Landmarks.FirstOrDefault().Landmark.Name;
            }
            

            if (selectorAdventureItem == null)
            {
                selectorAdventureItem = new SelectorAdventureItem()
                {
                    SelectorAdventureId = SelectorAdventureId,
                    Track = track,
                    PeakName = peakName,
                    LandmarkName = landmarkName,
                    Targets = 1
                    
                };

                _context.SelectorAdventureItems.Add(selectorAdventureItem);
            }
            else
            {
                selectorAdventureItem.Targets++;

            }
            _context.SaveChanges();
        }

        public void RemoveItemFromAdventure(Track track)
        {
            var selectorAdventureItem = _context.SelectorAdventureItems
               .FirstOrDefault(n => n.Track.Id == track.Id && n.SelectorAdventureId == SelectorAdventureId);

            if (selectorAdventureItem != null)
            {
                if (selectorAdventureItem.Targets >1)
                {
                    selectorAdventureItem.Targets--;
                }
                else
                {
                    _context.SelectorAdventureItems.Remove(selectorAdventureItem);

                }

            }
            _context.SaveChanges();
        }


        public List<SelectorAdventureItem> GetSelectorAdventureItems()
        {
            return SelectorAdventureItems ?? (SelectorAdventureItems = _context.SelectorAdventureItems
                .Where(n => n.SelectorAdventureId == SelectorAdventureId).Include(n => n.Track).ToList());
        }

        public double GetSelectorAdventureItemsTotalDate()
        {
            var startDate = _context.SelectorAdventureItems.Where(n => n.SelectorAdventureId == SelectorAdventureId).Select(n => n.Track.StartDate).FirstOrDefault();
            var endDate = _context.SelectorAdventureItems.Where(n => n.SelectorAdventureId == SelectorAdventureId).Select(n => n.Track.EndDate).FirstOrDefault();

            

            if (_context.SelectorAdventureItems.Where(n => n.SelectorAdventureId == SelectorAdventureId) == null  )
            {
                return days;
            }
            else
            {
                days += (startDate - endDate).TotalDays;
            return days;

            }
        }
    }
}
