// <auto-generated />
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
    [Migration("20211214184959_Register_Added")]
    partial class Register_Added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.AdventureOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdventureOrders");
                });

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

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

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amounmt")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.ToTable("OrderItems");
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

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.SelectorAdventureItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LandmarkName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeakName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectorAdventureId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Targets")
                        .HasColumnType("int");

                    b.Property<int?>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.ToTable("SelectorAdventureItems");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.OrderItem", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.AdventureOrder", "AdventureOrder")
                        .WithMany("OrderItems")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdventureOrder");

                    b.Navigation("Track");
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

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.SelectorAdventureItem", b =>
                {
                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId");

                    b.Navigation("Track");
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
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Mountain_Trips_and_Landmarks.Models.Track", "Track")
                        .WithMany("Tracks_Mountains")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.NoAction)
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

            modelBuilder.Entity("Mountain_Trips_and_Landmarks.Models.AdventureOrder", b =>
                {
                    b.Navigation("OrderItems");
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
