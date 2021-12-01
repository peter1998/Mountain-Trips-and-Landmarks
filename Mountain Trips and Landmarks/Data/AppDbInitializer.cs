using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Mountain_Trips_and_Landmarks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Mountains
                if (!context.Mountains.Any())
                {
                    context.Mountains.AddRange(new List<Mountain>()
                    {
                        new Mountain()
                        {
                            Name = "Vitosha",
                            Description = @"Vitosha  is a mountain massif, on the outskirts of Sofia, the capital of Bulgaria. Vitosha is one of the symbols of Sofia and the closest site for hiking, alpinism and skiing. Convenient bus lines and rope ways render the mountain easily accessible. Vitosha has the outlines of an enormous dome. The territory of the mountain includes 
                                            Vitosha nature park that encompasses the best known and most frequently visited parts.",
                            MountainPictureURL = "Image/mountain/vitosha.jpg",
                            TrekkingTime = 12,
                        },
                        new Mountain()
                        {
                            Name = "Pirin",
                            Description = @"The Pirin Mountains are a mountain range in southwestern Bulgaria, with Vihren at an altitude of 2,914 m being the highest peak. The range extends about 80 km from the north-west to the south-east and is about 40 km wide, spanning a territory of 2,585 km2 (998 sq mi). To the north Pirin is separated from Bulgaria's highest mountain range, the Rila Mountain, by the Predel saddle, while to the south it reaches the Slavyanka Mountain.",
                            MountainPictureURL = "Image/mountain/pirin.jpg",
                            TrekkingTime = 34,

                        },
                        new Mountain()
                        {
                            Name = "Rila",
                            Description = @"Rila  is the highest mountain range of Bulgaria, the Balkan Peninsula and Southeast Europe. It is situated in southwestern Bulgaria and forms part of the Rila–Rhodope Massif. The highest summit is Musala at an altitude of 2,925 m which makes Rila the sixth highest mountain range in Europe after the Caucasus, the Alps, Sierra Nevada, the Pyrenees and Mount Etna, and the highest one between the Alps and the Caucasus. It spans a territory of 2,629 km2 with an average altitude of 1487 m. The mountain is believed to have been named after the river of the same name, which comes from the Old Bulgarian verb (рыти) meaning (to grub).",
                            MountainPictureURL = "Image/mountain/rila.jpg",
                            TrekkingTime = 44,

                        },
                        new Mountain()
                        {
                            Name = "Rhodope Mountains",
                            Description = @"The Rhodopes  are a mountain range in Southeastern Europe, with over 83% of its area in southern Bulgaria and the remainder in Greece. Golyam Perelik is its highest peak at 2,191 meters (7,188 ft).
                                            The mountain range gives its name to the terrestrial ecoregion Rodope montane mixed forests that belongs in the temperate broadleaf and mixed forests biome and the Palearctic realm. The region is particularly notable for its karst areas with their deep river gorges, large caves and specific sculptured forms, such as the Trigrad Gorge.
                                            A significant part of Bulgaria's hydropower resources are located in the western areas of the range. There are a number of hydro-cascades and dams used for electricity production, irrigation, and as tourist destinations. In Greece, there are also the hydroelectric power plants of Thisavros and Platanovrysi. The Rhodopes have a rich cultural heritage including ancient Thracian sites such as Perperikon, Tatul and Belintash, and medieval castles, churches, monasteries, and picturesque villages with traditional Bulgarian architecture from the 18th and 19th centuries.",
                            MountainPictureURL = "Image/mountain/rhodopes.jpg",
                            TrekkingTime = 38,

                        }
                    });
                }
                //Landmarks
                if (!context.Landmarks.Any())
                {
                    context.Landmarks.AddRange(new List<Landmark>()
                    {
                        new Landmark()
                        {
                            Name = "Ski Zone Borovets",
                            Description = @"Borovets is the oldest Bulgarian winter resort with a history that dates back to 1896. Borovets was originally established at the end of the 19th Century as a hunting place for the Bulgarian Kings. Borovets gradually developed into a modern ski resort with hotels, restaurants, bars and a network of ski runs and lifts along the slopes of the Rila Mountains, providing for a whole range of winter sports. ",
                            LandmarkPictureURL = "Image/landmark/borovets.jpg",
                            Country = "Bulgaria Rila",

                        },
                        new Landmark()
                        {
                            Name = "Monastery of Saint Ivan of Rila",
                            Description = @"The Monastery of Saint Ivan of Rila, better known as the Rila Monastery  is the largest and most famous Eastern Orthodox monastery in Bulgaria. It is situated in the southwestern Rila Mountains, 117 km south of the capital Sofia in the deep valley of the Rilska River at an elevation of 1,147 m  above sea level, inside of Rila Monastery Nature Park. The monastery is named after its founder, the hermit Ivan of Rila, and houses around 60 monks.",
                            LandmarkPictureURL = "Image/landmark/RilaMonastery.jpg",
                            Country = "Bulgaria Rila",

                        },
                        new Landmark()
                        {
                            Name = "Bansko",
                            Description = @"Bansko is a town in southwestern Bulgaria, located at the foot of the Pirin Mountains at an elevation of 1200m above sea level. It is a ski resort.",
                            LandmarkPictureURL = "Image/landmark/Bansko.jpg",
                            Country = "Bulgaria Pirin",

                        },
                        new Landmark()
                        {
                            Name = "Pamporovo",
                            Description = @"Pamporovo is a popular ski resort in Smolyan Province, southern Bulgaria. It is set amongst Norway spruce forests and is primarily visited during the winter for skiing and snowboarding. It is also a popular tourist place in summer. The hub of Pamporovo comprises a number of hotels and bars. It is a family-friendly resort and suited for complete beginners and intermediates.",
                            LandmarkPictureURL = "Image/landmark/pamporovo.jpg",
                            Country = "Bulgaria Rhodopes",

                        },
                        new Landmark()
                        {
                            Name = "Golden Bridges",
                            Description = @"Zlatnite Mostove is the largest stone river on Vitosha Mountain, Bulgaria. The feature is situated in the valley of Vladayska River, extending 2.2 km, and up to 150 m wide, with several ‘tributary’ stone rivers. The stone river is ‘descending’ from elevation 1800 m above sea level in Boeritsa Chalet area to 1410 m at Zlatnite Mostove site. The lower extremity of the stone river is known as Zlatnite Mostove site, a popular tourist destination accessible from Sofia by road",
                            LandmarkPictureURL = "Image/landmark/zlatni_mostove.jpg",
                            Country = "Bulgaria Vitosha",

                        },
                    });
                }
                //Tracks
                if (!context.Tracks.Any())
                {
                    context.Tracks.AddRange(new List<Track>()
                    {
                        new Track()
                        {
                            StartingPoint = "Samokov",
                            EndPoint = "Ski Zone Borovets",
                            Highlights = "Fast Life Organization",
                            StartDate = DateTime.ParseExact("11/11/2021","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("02/02/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Ski

                        },
                        new Track()
                        {
                            StartingPoint = "Malyovishki Lakes",
                            EndPoint = "Monastery of Saint Ivan of Rila",
                            Highlights = "Green Mountain Highlights",
                            StartDate = DateTime.ParseExact("01/04/2022","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("01/09/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Expedition
                        },
                        new Track()
                        {
                            StartingPoint = "Banderishka polyana",
                            EndPoint = "Bansko",
                            Highlights = "Bulgaria Ski Hodilay",
                            StartDate = DateTime.ParseExact("11/11/2021","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("12/02/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Ski

                        },
                        new Track()
                        {
                            StartingPoint = "Little wall",
                            EndPoint = "Pamporovo",
                            Highlights = "Family DH track",
                            StartDate = DateTime.ParseExact("21/04/2021","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("04/06/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Downhill

                        },
                    });
                    //Peaks
                }
                //Peaks
                if (!context.Peaks.Any())
                {
                    context.Peaks.AddRange(new List<Peak>()
                        {
                            new Peak()
                            {
                                Name = "Kamenitsa Peak",
                                Logo = "Image/peak/Kamenitsa.jpg",
                                Description = @"Kamenitsa is a peak in the Pirin mountain range, south-western Bulgaria. It is located in the northern part of Pirin on the 22 km-long Kamenitsa secondary ridge between the summits of Malka Kamenitsa to the north and Yalovarnika (2,763 m) to the south. Its height is 2,822 m which ranks it on the fifth place in Pirin, behind Vihren (2,914 m), Kutelo (2,908 m), Banski Suhodol (2,884 m) and Polezhan (2,851 m). The peak is built up of granite blocks covered in lichens.",

                            },
                            new Peak()
                            {
                                Name = "Snejanka",
                                Logo = "Image/peak/Snejanka.jpg",
                                Description = "It is located 15 km from the town of Smolyan. The peak is 1926 m high and is the highest peak in the area of Pamporovo resort and Bukova mountain ridge. At the top is a TV tower with a height of 156 meters, which is located at an altitude of 2082 m. Its cafe-panorama of 2019 m has a great view.",

                            },
                            new Peak()
                            {
                                Name = "Musala",
                                Logo = "Image/peak/musala.jpg",
                                Description = @"Musala  from Arabic through Ottoman Turkish: from Musalla, (near God) or (place for prayer)  is the highest peak in the Rila Mountains, as well as in Bulgaria and the entire Balkan Peninsula, standing at 2,925 metres . With a topographic prominence of 2,473 metres , Musala is also the 6th highest peak by topographic prominence in mainland Europe. Musala is also the 3rd most topographically isolated major peak in Continental Europe",

                            },
                            new Peak()
                            {
                                Name = "Cherni Vruh",
                                Logo = "Image/peak/Cherni_Vruh.jpg",
                                Description = @"At the top there is a meteorological station, built in 1935 - shortly after the declaration of Vitosha National Park, the first of its kind on the Balkan Peninsula. The station has a small tourist tea house, as well as a post of the Mountain Rescue Service (MRS). From the top there is an incredible view of the Sofia plain, Stara Planina and Rila",

                            },
                        });
                    //Tracks_Landmarks
                    if (!context.Tracks_Landmarks.Any())
                    {
                        context.Tracks_Landmarks.AddRange(new List<Tracks_Landmarks>()
                            {
                                new Tracks_Landmarks()
                                {
                                    TrackId = 1,
                                    LandmarkId = 1
                                },
                                 new Tracks_Landmarks()
                                {
                                    TrackId = 2,
                                    LandmarkId = 2
                                },
                                  new Tracks_Landmarks()
                                {
                                    TrackId = 1,
                                    LandmarkId = 3
                                },
                                   new Tracks_Landmarks()
                                {
                                    TrackId = 3,
                                    LandmarkId = 4
                                },

                            });
                        //Tracks_Mountains
                        if (!context.Tracks_Mountains.Any())
                        {
                            context.Tracks_Mountains.AddRange(new List<Tracks_Mountains>()
                            {
                                new Tracks_Mountains()
                                {
                                    TrackId = 1,
                                    MountainId = 3
                                },
                                 new Tracks_Mountains()
                                {
                                    TrackId = 2,
                                    MountainId = 4
                                },
                                  new Tracks_Mountains()
                                {
                                    TrackId = 1,
                                    MountainId = 2
                                },
                                   new Tracks_Mountains()
                                {
                                    TrackId = 3,
                                    MountainId = 1
                                },

                            });
                        }
                        //Tracks_Peaks
                        if (!context.Tracks_Peaks.Any())
                        {
                            context.Tracks_Peaks.AddRange(new List<Tracks_Peaks>()
                            {
                                new Tracks_Peaks()
                                {
                                    TrackId = 1,
                                    PeakId = 1
                                },
                                 new Tracks_Peaks()
                                {
                                    TrackId = 2,
                                    PeakId = 4
                                },
                                  new Tracks_Peaks()
                                {
                                    TrackId = 1,
                                    PeakId = 3
                                },
                                   new Tracks_Peaks()
                                {
                                    TrackId = 3,
                                    PeakId = 2
                                },

                            });
                        }
                        //Peak_Mountain
                        if (!context.Peaks_Mountains.Any())
                        {
                            context.Peaks_Mountains.AddRange(new List<Peak_Mountain>()
                            {
                                new Peak_Mountain()
                                {
                                    PeakId = 1,
                                    MountainId = 1
                                },
                                 new Peak_Mountain()
                                {
                                    PeakId = 2,
                                    MountainId = 2
                                },
                                  new Peak_Mountain()
                                {
                                    PeakId = 3,
                                    MountainId = 3
                                },
                                   new Peak_Mountain()
                                {
                                    PeakId = 4,
                                    MountainId = 4
                                },

                            });
                        }
                        //Landmars_Mountains
                        if (!context.Landmarks_Mountains.Any())
                        {
                            context.Landmarks_Mountains.AddRange(new List<Landmarks_Mountains>()
                            {
                                new Landmarks_Mountains()
                                {
                                    LandmarkId = 1,
                                    MountainId = 1
                                },
                                 new Landmarks_Mountains()
                                {
                                    LandmarkId = 2,
                                    MountainId = 2
                                },
                                  new Landmarks_Mountains()
                                {
                                    LandmarkId = 3,
                                    MountainId = 3
                                },
                                   new Landmarks_Mountains()
                                {
                                    LandmarkId = 4,
                                    MountainId = 4
                                },

                            });
                            context.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}
