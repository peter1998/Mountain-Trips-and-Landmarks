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
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tracks_Peaks>().HasKey(am => new
            {
                am.TrackId,
                am.PeakId
            });

            modelBuilder.Entity<Tracks_Peaks>().HasOne(m => m.Peak).WithMany(am => am.Tracks_Peaks).HasForeignKey(m => m.PeakId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Peaks_Mountains>().HasKey(am => new
            {
                am.PeakId,
                am.MountainId
            });

            modelBuilder.Entity<Peaks_Mountains>().HasOne(m => m.Peak).WithMany(am => am.Peaks_Mountains).HasForeignKey(m => m.PeakId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Peaks_Mountains>().HasOne(m => m.Mountain).WithMany(am => am.Peaks_Mountains).HasForeignKey(m => m.MountainId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Tracks_Landmarks>().HasKey(am => new
            {
                am.TrackId,
                am.LandmarkId
            });

            modelBuilder.Entity<Tracks_Landmarks>().HasOne(m => m.Track).WithMany(am => am.Tracks_Landmarks).HasForeignKey(m => m.TrackId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Tracks_Landmarks>().HasOne(m => m.Landmark).WithMany(am => am.Tracks_Landmarks).HasForeignKey(m => m.LandmarkId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Tracks_Mountains>().HasKey(am => new
            {
                am.TrackId,
                am.MountainId
            });

            modelBuilder.Entity<Tracks_Mountains>().HasOne(m => m.Track).WithMany(am => am.Tracks_Mountains).HasForeignKey(m => m.TrackId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Tracks_Mountains>().HasOne(m => m.Mountain).WithMany(am => am.Tracks_Mountains).HasForeignKey(m => m.MountainId).OnDelete(DeleteBehavior.NoAction);

            // ? samo landmarsk_Mountains mrunka purvo
            modelBuilder.Entity<Landmarks_Mountains>().HasKey(am => new
            {
                am.LandmarkId,
                am.MountainId
            });

            modelBuilder.Entity<Landmarks_Mountains>().HasOne(m => m.Landmark).WithMany(am => am.Landmarks_Mountains).HasForeignKey(m => m.LandmarkId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Landmarks_Mountains>().HasOne(m => m.Mountain).WithMany(am => am.Landmarks_Mountains).HasForeignKey(m => m.MountainId).OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Mountain> Mountains { get; set; }
        public DbSet<Peak> Peaks { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Landmark> Landmarks { get; set; }

        public DbSet<Tracks_Peaks> Tracks_Peaks { get; set; }
        public DbSet<Peaks_Mountains> Peaks_Mountains { get; set; }
        public DbSet<Tracks_Landmarks> Tracks_Landmarks { get; set; }
        public DbSet<Tracks_Mountains> Tracks_Mountains { get; set; }
        public DbSet<Landmarks_Mountains> Landmarks_Mountains { get; set; }

        //Orders related tables
        public DbSet<AdventureOrder> AdventureOrders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<SelectorAdventureItem> SelectorAdventureItems { get; set; }
    }
}
