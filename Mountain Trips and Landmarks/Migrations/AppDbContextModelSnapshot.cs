﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mountain_Trips_and_Landmarks.Data;

namespace Mountain_Trips_and_Landmarks.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Landmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandmarkPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MountainId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MountainId");

                    b.ToTable("Landmarks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Landmarks_Mountains", b =>
                {
                    b.Property<int>("LandmarkId")
                        .HasColumnType("int");

                    b.Property<int?>("MountainId")
                        .HasColumnType("int");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.HasKey("LandmarkId", "MountainId");

                    b.HasIndex("MountainId");

                    b.ToTable("Landmarks_Mountains");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Mountain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MountainPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrekkingTime")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Mountains");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Peak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MountainId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MountainId");

                    b.ToTable("Peaks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Peaks_Mountains", b =>
                {
                    b.Property<int?>("PeakId")
                        .HasColumnType("int");

                    b.Property<int?>("MountainId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("PeakId", "MountainId");

                    b.HasIndex("MountainId");

                    b.ToTable("Peaks_Mountains");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Highlights")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LandmarkId")
                        .HasColumnType("int");

                    b.Property<int?>("MountainId")
                        .HasColumnType("int");

                    b.Property<int?>("PeakId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartingPoint")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrackCategory")
                        .HasColumnType("int");

                    b.Property<string>("TrackCateogryURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LandmarkId");

                    b.HasIndex("MountainId");

                    b.HasIndex("PeakId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Landmarks", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int?>("LandmarkId")
                        .HasColumnType("int");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.HasKey("TrackId", "LandmarkId");

                    b.HasIndex("LandmarkId");

                    b.ToTable("Tracks_Landmarks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Mountains", b =>
                {
                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.Property<int?>("MountainId")
                        .HasColumnType("int");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.HasKey("TrackId", "MountainId");

                    b.HasIndex("MountainId");

                    b.ToTable("Tracks_Mountains");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Peaks", b =>
                {
                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.Property<int?>("PeakId")
                        .HasColumnType("int");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.HasKey("TrackId", "PeakId");

                    b.HasIndex("PeakId");

                    b.ToTable("Tracks_Peaks");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Landmark", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Landmarks")
                        .HasForeignKey("MountainId");

                    b.Navigation("Mountain");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Landmarks_Mountains", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Landmark", "Landmark")
                        .WithMany("Landmarks_Mountains")
                        .HasForeignKey("LandmarkId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Landmarks_Mountains")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Landmark");

                    b.Navigation("Mountain");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Peak", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", null)
                        .WithMany("Peaks")
                        .HasForeignKey("MountainId");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Peaks_Mountains", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Peaks_Mountains")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Peak", "Peak")
                        .WithMany("Peaks_Mountains")
                        .HasForeignKey("PeakId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Mountain");

                    b.Navigation("Peak");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Track", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Landmark", "landmark")
                        .WithMany("Tracks")
                        .HasForeignKey("LandmarkId");

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany()
                        .HasForeignKey("MountainId");

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Peak", "Peak")
                        .WithMany("Tracks")
                        .HasForeignKey("PeakId");

                    b.Navigation("landmark");

                    b.Navigation("Mountain");

                    b.Navigation("Peak");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Landmarks", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Landmark", "Landmark")
                        .WithMany("Tracks_Landmarks")
                        .HasForeignKey("LandmarkId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Track", "Track")
                        .WithMany("Tracks_Landmarks")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Landmark");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Mountains", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Mountain", "Mountain")
                        .WithMany("Tracks_Mountains")
                        .HasForeignKey("MountainId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Track", "Track")
                        .WithMany("Tracks_Mountains")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Mountain");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.Tracks_Peaks", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Peak", "Peak")
                        .WithMany("Tracks_Peaks")
                        .HasForeignKey("PeakId")
                        .OnDelete(DeleteBehavior.Restrict)
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
