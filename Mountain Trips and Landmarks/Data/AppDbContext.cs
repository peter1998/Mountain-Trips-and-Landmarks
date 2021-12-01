using Microsoft.EntityFrameworkCore;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Peak_Mountain>().HasKey(pm => new
            {
                pm.PeakId,
                pm.MountainId
            });
           // modelBuilder.Entity<Peak_Mountain>().HasOne(m => m.Mountain)
             //   .WithMany(pm => pm.Peaks_Mountains).HasForeignKey(m => m.MountainId);
            //modelBuilder.Entity<Peak_Mountain>().HasOne(m => m.Peak)
             //   .WithMany(pm => pm.Peaks_Mountains).HasForeignKey(m => m.PeakId);

            modelBuilder.Entity<Landmarks_Mountains>().HasKey(lm => new
            {
                lm.LandmarkId,
                lm.MountainId
            });

            //modelBuilder.Entity<Landmarks_Mountains>().HasOne(m => m.Mountain)
            //    .WithMany(lm => lm.Landmarks_Mountains).HasForeignKey(m => m.MountainId);
            //modelBuilder.Entity<Landmarks_Mountains>().HasOne(m => m.Landmark)
            //    .WithMany(lm => lm.Landmarks_Mountains).HasForeignKey(m => m.LandmarkId);

            modelBuilder.Entity<Tracks_Mountains>().HasKey(tm => new
            {
                tm.TrackId,
                tm.MountainId
            });
           // modelBuilder.Entity<Tracks_Mountains>().HasOne(m => m.Mountain)
            //    .WithMany(pm => pm.Tracks_Mountains).HasForeignKey(m => m.MountainId);
            //modelBuilder.Entity<Tracks_Mountains>().HasOne(m => m.Track)
            //    .WithMany(pm => pm.Tracks_Mountains).HasForeignKey(m => m.TrackId);

            modelBuilder.Entity<Tracks_Peaks>().HasKey(tp => new
            {
                tp.TrackId,
                tp.PeakId
            });
           // modelBuilder.Entity<Tracks_Peaks>().HasOne(p => p.Peak)
              //  .WithMany(pm => pm.Tracks_Peaks).HasForeignKey(p => p.PeakId);
            //modelBuilder.Entity<Tracks_Peaks>().HasOne(m => m.Track)
            //    .WithMany(pm => pm.Tracks_Peaks).HasForeignKey(m => m.TrackId);

            modelBuilder.Entity<Tracks_Landmarks>().HasKey(tl => new
            {
                tl.TrackId,
                tl.LandmarkId
            });
           // modelBuilder.Entity<Tracks_Landmarks>().HasOne(l => l.Landmark)
               // .WithMany(pm => pm.Tracks_Landmarks).HasForeignKey(l => l.LandmarkId);
            //modelBuilder.Entity<Tracks_Landmarks>().HasOne(m => m.Track)
            //    .WithMany(pm => pm.Tracks_Landmarks).HasForeignKey(m => m.TrackId);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Mountain> Mountains { get; set; }
        public DbSet<Peak> Peaks { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Landmark> Landmarks { get; set; }
        public DbSet<Peak_Mountain> Peaks_Mountains { get; set; }
        public DbSet<Tracks_Mountains> Tracks_Mountains { get; set; }
        public DbSet<Tracks_Peaks> Tracks_Peaks { get; set; }
        public DbSet<Tracks_Landmarks> Tracks_Landmarks { get; set; }
        public DbSet<Landmarks_Mountains> Landmarks_Mountains { get; set; }

    }
}
