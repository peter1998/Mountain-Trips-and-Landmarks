﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mountain_Trips_and_Landmarks.Data;

namespace Mountain_Trips_and_Landmarks.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211201142123_initialSetUp")]
    partial class initialSetUp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Landmark", b =>
                {
                    b.Property<int>("LandmarksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandmarkPictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MountainId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LandmarksId");

                    b.HasIndex("MountainId");

                    b.ToTable("Landmarks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Landmarks_Mountains", b =>
                {
                    b.Property<int>("LandmarkId")
                        .HasColumnType("int");

                    b.Property<int>("MountainId")
                        .HasColumnType("int");

                    b.HasKey("LandmarkId", "MountainId");

                    b.HasIndex("MountainId");

                    b.ToTable("Landmarks_Mountains");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Mountain", b =>
                {
                    b.Property<int>("MountainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MountainPictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrekkingTime")
                        .HasColumnType("int");

                    b.HasKey("MountainId");

                    b.ToTable("Mountains");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Peak", b =>
                {
                    b.Property<int>("PeakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MountainId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PeakId");

                    b.HasIndex("MountainId");

                    b.ToTable("Peaks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Peak_Mountain", b =>
                {
                    b.Property<int>("PeakId")
                        .HasColumnType("int");

                    b.Property<int>("MountainId")
                        .HasColumnType("int");

                    b.HasKey("PeakId", "MountainId");

                    b.HasIndex("MountainId");

                    b.ToTable("Peaks_Mountains");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Highlights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LandmarkId")
                        .HasColumnType("int");

                    b.Property<int>("MountainId")
                        .HasColumnType("int");

                    b.Property<int>("PeakId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartingPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackCategory")
                        .HasColumnType("int");

                    b.HasKey("TrackId");

                    b.HasIndex("LandmarkId");

                    b.HasIndex("MountainId");

                    b.HasIndex("PeakId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Landmarks", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int>("LandmarkId")
                        .HasColumnType("int");

                    b.HasKey("TrackId", "LandmarkId");

                    b.HasIndex("LandmarkId");

                    b.ToTable("Tracks_Landmarks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Mountains", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int>("MountainId")
                        .HasColumnType("int");

                    b.HasKey("TrackId", "MountainId");

                    b.HasIndex("MountainId");

                    b.ToTable("Tracks_Mountains");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Peaks", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int>("PeakId")
                        .HasColumnType("int");

                    b.HasKey("TrackId", "PeakId");

                    b.HasIndex("PeakId");

                    b.ToTable("Tracks_Peaks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Landmark", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Landmarks")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mountain");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Landmarks_Mountains", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Landmark", "Landmark")
                        .WithMany("Landmarks_Mountains")
                        .HasForeignKey("LandmarkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Landmarks_Mountains")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landmark");

                    b.Navigation("Mountain");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Peak", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Peaks")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mountain");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Peak_Mountain", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Peaks_Mountains")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Peak", "Peak")
                        .WithMany("Peaks_Mountains")
                        .HasForeignKey("PeakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mountain");

                    b.Navigation("Peak");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Track", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Landmark", "Landmark")
                        .WithMany("Tracks")
                        .HasForeignKey("LandmarkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Tracks")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Peak", "Peak")
                        .WithMany("Tracks")
                        .HasForeignKey("PeakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landmark");

                    b.Navigation("Mountain");

                    b.Navigation("Peak");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Landmarks", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Landmark", "Landmark")
                        .WithMany("Tracks_Landmarks")
                        .HasForeignKey("LandmarkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Track", "Track")
                        .WithMany("Tracks_Landmarks")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landmark");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Mountains", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Tracks_Mountains")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Track", "Track")
                        .WithMany("Tracks_Mountains")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mountain");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Peaks", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Peak", "Peak")
                        .WithMany("Tracks_Peaks")
                        .HasForeignKey("PeakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Track", "Track")
                        .WithMany("Tracks_Peaks")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Peak");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Landmark", b =>
                {
                    b.Navigation("Landmarks_Mountains");

                    b.Navigation("Tracks");

                    b.Navigation("Tracks_Landmarks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Mountain", b =>
                {
                    b.Navigation("Landmarks");

                    b.Navigation("Landmarks_Mountains");

                    b.Navigation("Peaks");

                    b.Navigation("Peaks_Mountains");

                    b.Navigation("Tracks");

                    b.Navigation("Tracks_Mountains");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Peak", b =>
                {
                    b.Navigation("Peaks_Mountains");

                    b.Navigation("Tracks");

                    b.Navigation("Tracks_Peaks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Track", b =>
                {
                    b.Navigation("Tracks_Landmarks");

                    b.Navigation("Tracks_Mountains");

                    b.Navigation("Tracks_Peaks");
                });
#pragma warning restore 612, 618
        }
    }
}
