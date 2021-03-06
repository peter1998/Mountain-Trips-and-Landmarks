using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Mountain_Trips_and_Landmarks.Data.Static;
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
            //Mountain
            Stack<Mountain> mountainStack = new Stack<Mountain>();
            List<Mountain> mountainList = new List<Mountain>();

            //Peak
            Stack<Peak> peakStack = new Stack<Peak>();
            List<Peak> PeakList = new List<Peak>();

            //Landmark
            Stack<Landmark> landmarkStack = new Stack<Landmark>();
            List<Landmark> landmarkList = new List<Landmark>();

            //Track
            Stack<Track> trackStack = new Stack<Track>();
            List<Track> trackList = new List<Track>();

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Peaks.Any())
                {
                    context.Peaks.AddRange(new List<Peak>()
                        {
                            new Peak()
                            {
                                Name = "Kamenitsa Peak",
                                Logo = "https://media.istockphoto.com/photos/kamenitsa-peak-and-its-reflection-in-a-lake-in-pirin-national-park-picture-id1341488783",
                                Description = @"Kamenitsa is a peak in the Pirin mountain range, south-western Bulgaria. It is located in the northern part of Pirin on the 22 km-long
Kamenitsa secondary ridge between the summits of Malka Kamenitsa to the north and Yalovarnika (2,763 m) to the south. Its height is 2,822 m which ranks it on the fifth place in Pirin, behind Vihren (2,914 m), Kutelo (2,908 m), Banski Suhodol (2,884 m) and Polezhan (2,851 m). The peak is built up of granite blocks covered in lichens.",

                            },
                            new Peak()
                            {
                                Name = "Snejanka",
                                Logo = "https://media.istockphoto.com/photos/rhodopes-mountain-bulgaria-picture-id846763058",
                                Description = @"It is located 15 km from the town of Smolyan. The peak is 1926 m high and is the highest peak in the area of Pamporovo resort an +
                                d Bukova mountain ridge. At the top is a TV tower with a height of 156 meters, which is located at an altitude of 2082 m. Its cafe-panorama of 2019 m has a great view.",

                            },
                            new Peak()
                            {
                                Name = "Musala",
                                Logo = "https://media.istockphoto.com/photos/ledenoto-lake-from-musala-peak-rila-mountain-picture-id613659486",
                                Description = @"Musala  from Arabic through Ottoman Turkish: from Musalla, (near God) or (place for prayer)  is the highes
t peak in the Rila Mountains, as well as in Bulgaria and the entire Balkan Peninsula, standing at 2,925 metres . With a topographic prominence of 2,473 metres , Musala is also the 6th highest peak by topographic prominence in mainland Europe. Musala is also the 3rd most topographically isolated major peak in Continental Europe",

                            },
                            new Peak()
                            {
                                Name = "Cherni Vruh",
                                Logo = "https://media.istockphoto.com/photos/landscape-of-vitosha-mountain-from-cherni-vrah-peak-sofia-city-region-picture-id1091206830",
                                Description = @"At the top there is a meteorological station, built in 1935 - shortly after the declaration of Vitosha National Park, the first of 
its kind on the Balkan Peninsula. The station has a small tourist tea house, as well as a post of the Mountain Rescue Service (MRS). From the top there is an incredible view of the Sofia plain, Stara Planina and Rila",

                            },
                            new Peak()
                            {
                                Name = "Shipka monument peak",
                                Logo = "https://media.istockphoto.com/photos/liberty-monument-of-shipka-picture-id1156245258?s=2048x2048",
                                Description = @"Sveti Nikola (Shipka) is a peak in the Balkan Mountains with an altitude of 1326 m, located east of the Shipka Pass. Until November 23, 1951 the peak was named St. Nicholas, and then until October 7, 1977 - Stoletov peak. The peak symbolizes the heroism and self-sacrificing efforts for the liberation of Bulgaria from Ottoman rule.",

                            },
                              new Peak()
                            {
                                Name = "Koncheto ridge",
                                Logo = "https://media.istockphoto.com/photos/part-of-the-koncheto-ridge-picture-id175325603?s=2048x2048",
                                Description = @"Koncheto is a steep and difficult to access saddle in the Northern Pirin. It is located on the main mountain ridge at 2810 m. It occupies the lowest and narrowest part of the karst edge between the peaks Banski Suhodol from the northwest and Kutelo from the southeast. The length of the edge is about 400 m, and its narrowest part is about 150 m.",

                            },
                        });
                }

                PeakList.AddRange(new List<Peak>()
                    {
                            new Peak()
                            {
                                Name = "Kamenitsa Peak",
                                Logo = "https://media.istockphoto.com/photos/kamenitsa-peak-and-its-reflection-in-a-lake-in-pirin-national-park-picture-id1341488783",
                                Description = @"Kamenitsa is a peak in the Pirin mountain range, south-western Bulgaria. It is located in the northern part of Pirin on the 22 km-long
Kamenitsa secondary ridge between the summits of Malka Kamenitsa to the north and Yalovarnika (2,763 m) to the south. Its height is 2,822 m which ranks it on the fifth place in Pirin, behind Vihren (2,914 m), Kutelo (2,908 m), Banski Suhodol (2,884 m) and Polezhan (2,851 m). The peak is built up of granite blocks covered in lichens.",

                            },
                            new Peak()
                            {
                                Name = "Snejanka",
                                Logo = "https://media.istockphoto.com/photos/rhodopes-mountain-bulgaria-picture-id846763058",
                                Description = @"It is located 15 km from the town of Smolyan. The peak is 1926 m high and is the highest peak in the area of Pamporovo resort an +
                                d Bukova mountain ridge. At the top is a TV tower with a height of 156 meters, which is located at an altitude of 2082 m. Its cafe-panorama of 2019 m has a great view.",

                            },
                            new Peak()
                            {
                                Name = "Musala",
                                Logo = "https://media.istockphoto.com/photos/ledenoto-lake-from-musala-peak-rila-mountain-picture-id613659486",
                                Description = @"Musala  from Arabic through Ottoman Turkish: from Musalla, (near God) or (place for prayer)  is the highes
t peak in the Rila Mountains, as well as in Bulgaria and the entire Balkan Peninsula, standing at 2,925 metres . With a topographic prominence of 2,473 metres , Musala is also the 6th highest peak by topographic prominence in mainland Europe. Musala is also the 3rd most topographically isolated major peak in Continental Europe",

                            },
                            new Peak()
                            {
                                Name = "Cherni Vruh",
                                Logo = "https://media.istockphoto.com/photos/landscape-of-vitosha-mountain-from-cherni-vrah-peak-sofia-city-region-picture-id1091206830",
                                Description = @"At the top there is a meteorological station, built in 1935 - shortly after the declaration of Vitosha National Park, the first of 
its kind on the Balkan Peninsula. The station has a small tourist tea house, as well as a post of the Mountain Rescue Service (MRS). From the top there is an incredible view of the Sofia plain, Stara Planina and Rila",

                            },
                             new Peak()
                            {
                                Name = "Shipka monument peak",
                                Logo = "https://media.istockphoto.com/photos/liberty-monument-of-shipka-picture-id1156245258?s=2048x2048",
                                Description = @"Sveti Nikola (Shipka) is a peak in the Balkan Mountains with an altitude of 1326 m, located east of the Shipka Pass. Until November 23, 1951 the peak was named St. Nicholas, and then until October 7, 1977 - Stoletov peak. The peak symbolizes the heroism and self-sacrificing efforts for the liberation of Bulgaria from Ottoman rule.",

                            },
                              new Peak()
                            {
                                Name = "Koncheto ridge",
                                Logo = "https://media.istockphoto.com/photos/part-of-the-koncheto-ridge-picture-id175325603?s=2048x2048",
                                Description = @"Koncheto is a steep and difficult to access saddle in the Northern Pirin. It is located on the main mountain ridge at 2810 m. It occupies the lowest and narrowest part of the karst edge between the peaks Banski Suhodol from the northwest and Kutelo from the southeast. The length of the edge is about 400 m, and its narrowest part is about 150 m.",

                            },
                        });

                Stack<Peak> peakStackInitializer = new Stack<Peak>(PeakList);
                Stack<Peak> peakListStackInitializer = new Stack<Peak>(PeakList);


                Stack<Peak> mountainseedStackInitializer = new Stack<Peak>(PeakList);
                Stack<Peak> mountainseedListStackInitializer = new Stack<Peak>(PeakList);


                if (!context.Mountains.Any())
                {

                    context.Mountains.AddRange(new List<Mountain>()
                    {
                         new Mountain()
                        {
                            Name = "Rila",
                            Description = @"Rila  is the highest mountain range of Bulgaria, the Balkan Peninsula and Southeast Europe. It is situated in southwestern Bulgaria and forms 
part of the Rila–Rhodope Massif. The highest summit is Musala at an altitude of 2,925 m which makes Rila the sixth highest mountain range in Europe after the Caucasus, the Alps, Sierra Nevada, the Pyrenees and Mount Etna, and the highest one between the Alps and the Caucasus. It spans a territory of 2,629 km2 with an average altitude of 1487 m. The mountain is believed to have been named after the river of the same name, which comes from the Old Bulgarian verb (рыти) meaning (to grub).",
                            MountainPictureURL = "https://media.istockphoto.com/photos/seven-rila-lakes-view-picture-id479305282",
                            TrekkingTime = 44,
                            //Peaks=mountainseedStackInitializer.Pop(),
                        },
                          new Mountain()
                        {
                            Name = "Pirin",
                            Description = @"The Pirin Mountains are a mountain range in southwestern Bulgaria, with Vihren at an altitude of
                                2,914 m being the highest peak. The range extends about 80 km from the north-west to the south-east and is about 40 km wide, spanning a territory of 2,585 km2 (998 sq mi). To the north Pirin is separated from Bulgaria's highest mountain range, the Rila Mountain, by the Predel saddle, while to the south it reaches the Slavyanka Mountain.",
                            MountainPictureURL = "https://media.istockphoto.com/photos/lake-in-pirin-mountains-picture-id652141002",
                            TrekkingTime = 34,

                        },
                           new Mountain()
                        {

                            Name = "Rhodope Mountains",
                            Description = @"The Rhodopes  are a mountain range in Southeastern Europe, with over 83% of its area in southern Bulgaria and the remainder in Greece. Golyam Perelik is its highest peak at 2,191 meters (7,188 ft).
                                            The mountain range gives its name to the terrestrial ecoregion Rodope montane mixed forests that belongs in the temperate broadleaf and mixed forests biome and the Palearctic realm. The region is particularly notable for its karst areas with their deep river gorges, large caves and specific sculptured forms, such as the Trigrad Gorge.
                                            A significant part of Bulgaria's hydropower resources are located in the western areas of the range. There are a number of hydro-cascades and dams used for electricity production, irrigation, and as tourist destinations. In Greece, there are also the hydroelectric power plants of Thisavros and Platanovrysi. The Rhodopes have a rich cultural heritage including ancient Thracian sites such as Perperikon, Tatul and Belintash, and medieval castles, churches, monasteries, and picturesque villages with traditional Bulgarian architecture from the 18th and 19th centuries.",
                            MountainPictureURL = "https://media.istockphoto.com/photos/belintash-rock-sanctuary-bulgaria-picture-id1308301502",
                            TrekkingTime = 38,

                        },
                            new Mountain()
                        {
                            Name = "Stara Planina Mountain",
                            Description = @"It stretches east of the Belogradchik Pass between the municipality of Belogradchik, Vidin district, and the municipality of Knjaževac, Zajec
ar district to Cape Emine on the Black Sea to the east. Most of it is located on the territory of Bulgaria, located along the page, conditionally dividing it into Northern and Southern Bulgaria. The highest point is Botev peak (2375.9 m). In its land there are many natural parks, protected areas and a national park. It is one of the largest centers of endemic and relict species. There are 81 built-in huts. Tips from the added material base, clean air and high mountain nature Stara Planina is often a preferred destination for tourism and recreation.",
                            MountainPictureURL = "https://media.istockphoto.com/photos/stara-planina-mountain-view-picture-id1043483210",
                            TrekkingTime = 10,

                        },
                             new Mountain()
                        {
                            Name = "Verila Mountain",
                            Description = @"Verila Mountainis a minor range in Western Bulgaria extending 20 km in northwest–southeast direction between Vitosha and Rila Mountains
and 12 km wide. Its summit Golyam Debelets Peak rises to 1415 m",
                            MountainPictureURL = "https://media.istockphoto.com/photos/plana-and-rila-mountains-picture-id1158413462",
                            TrekkingTime = 22,

                        },
                        new Mountain()
                        {

                            Name = "Vitosha",
                            Description = @"Vitosha  is a mountain massif, on the outskirts of Sofia, the capital of Bulgaria. Vitosha is one of the symbols of Sofia and the closest site for hiking, alpinism and skiing. Convenient bus lines and rope ways render the mountain easily accessible. Vitosha has the outlines of an enormous dome. The territory of the mountain includes 
                                            Vitosha nature park that encompasses the best known and most frequently visited parts.",
                            MountainPictureURL = "https://media.istockphoto.com/photos/landscape-with-moraine-at-vitosha-mountain-bulgaria-picture-id1203508303",
                            TrekkingTime = 12,
                        }
                    });
                }
               
                // Needed list to give the Track the mountain property

                mountainList.AddRange(new List<Mountain>()
                    {
                        new Mountain()
                        {
                            Name = "Vitosha",
                            Description = @"Vitosha  is a mountain massif, on the outskirts of Sofia, the capital of Bulgaria. Vitosha is one of the symbols of Sofia and the closest site for hiking, alpinism and skiing. Convenient bus lines and rope ways render the mountain easily accessible. Vitosha has the outlines of an enormous dome. The territory of the mountain includes 
                                            Vitosha nature park that encompasses the best known and most frequently visited parts.",
                            MountainPictureURL = "https://media.istockphoto.com/photos/landscape-with-moraine-at-vitosha-mountain-bulgaria-picture-id1203508303",
                            TrekkingTime = 12,
                        },
                        new Mountain()
                        {
                            Name = "Pirin",
                            Description = @"The Pirin Mountains are a mountain range in southwestern Bulgaria, with Vihren at an altitude of
                                2,914 m being the highest peak. The range extends about 80 km from the north-west to the south-east and is about 40 km wide, spanning a territory of 2,585 km2 (998 sq mi). To the north Pirin is separated from Bulgaria's highest mountain range, the Rila Mountain, by the Predel saddle, while to the south it reaches the Slavyanka Mountain.",
                            MountainPictureURL = "https://media.istockphoto.com/photos/lake-in-pirin-mountains-picture-id652141002",
                            TrekkingTime = 34,

                        },
                        new Mountain()
                        {
                            Name = "Rila",
                            Description = @"Rila  is the highest mountain range of Bulgaria, the Balkan Peninsula and Southeast Europe. It is situated in southwestern Bulgaria and forms 
part of the Rila–Rhodope Massif. The highest summit is Musala at an altitude of 2,925 m which makes Rila the sixth highest mountain range in Europe after the Caucasus, the Alps, Sierra Nevada, the Pyrenees and Mount Etna, and the highest one between the Alps and the Caucasus. It spans a territory of 2,629 km2 with an average altitude of 1487 m. The mountain is believed to have been named after the river of the same name, which comes from the Old Bulgarian verb (рыти) meaning (to grub).",
                            MountainPictureURL = "https://media.istockphoto.com/photos/seven-rila-lakes-view-picture-id479305282",
                            TrekkingTime = 44,

                        },
                        new Mountain()
                        {
                            Name = "Rhodope Mountains",
                            Description = @"The Rhodopes  are a mountain range in Southeastern Europe, with over 83% of its area in southern Bulgaria and the remainder in Greece. Golyam Perelik is its highest peak at 2,191 meters (7,188 ft).
                                            The mountain range gives its name to the terrestrial ecoregion Rodope montane mixed forests that belongs in the temperate broadleaf and mixed forests biome and the Palearctic realm. The region is particularly notable for its karst areas with their deep river gorges, large caves and specific sculptured forms, such as the Trigrad Gorge.
                                            A significant part of Bulgaria's hydropower resources are located in the western areas of the range. There are a number of hydro-cascades and dams used for electricity production, irrigation, and as tourist destinations. In Greece, there are also the hydroelectric power plants of Thisavros and Platanovrysi. The Rhodopes have a rich cultural heritage including ancient Thracian sites such as Perperikon, Tatul and Belintash, and medieval castles, churches, monasteries, and picturesque villages with traditional Bulgarian architecture from the 18th and 19th centuries.",
                            MountainPictureURL = "https://media.istockphoto.com/photos/belintash-rock-sanctuary-bulgaria-picture-id1308301502",
                            TrekkingTime = 38,

                        },

                        new Mountain()
                        {
                            Name = "Stara Planina Mountain",
                            Description = @"It stretches east of the Belogradchik Pass between the municipality of Belogradchik, Vidin district, and the municipality of Knjaževac, Zajec
ar district to Cape Emine on the Black Sea to the east. Most of it is located on the territory of Bulgaria, located along the page, conditionally dividing it into Northern and Southern Bulgaria. The highest point is Botev peak (2375.9 m). In its land there are many natural parks, protected areas and a national park. It is one of the largest centers of endemic and relict species. There are 81 built-in huts. Tips from the added material base, clean air and high mountain nature Stara Planina is often a preferred destination for tourism and recreation.",
                            MountainPictureURL = "https://media.istockphoto.com/photos/stara-planina-mountain-view-picture-id1043483210",
                            TrekkingTime = 10,
                        },
                    new Mountain()
                        {
                            Name = "Verila",
                            Description = @"Verila Mountainis a minor range in Western Bulgaria extending 20 km in northwest–southeast direction between Vitosha and 
Rila Mountains and 12 km wide. Its summit Golyam Debelets Peak rises to 1415 m",
                            MountainPictureURL = "https://media.istockphoto.com/photos/stara-planina-mountain-view-picture-id1043483210",
                            TrekkingTime = 38,

                        }
                });
                Stack<Mountain> mountainStackInitializer = new Stack<Mountain>(mountainList);
                Stack<Mountain> mountainListStackInitializer = new Stack<Mountain>(mountainList);

                landmarkList.AddRange(new List<Landmark>(){
                     new Landmark()
                        {
                            Name = "Ski Zone Borovets",
                            Description = @"Borovets is the oldest Bulgarian winter resort with a history that dates back to 1896. Borovets was originally establis
hed at the end of the 19th Century as a hunting place for the Bulgarian Kings. Borovets gradually developed into a modern ski resort with hotels, restaurants, bars and a network of ski runs and lifts along the slopes of the Rila Mountains, providing for a whole range of winter sports. ",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/mountain-forest-arkhyz-picture-id500694572",
                            Country = "Bulgaria Rila",

                        },
                        new Landmark()
                        {
                            Name = "Monastery of Saint Ivan of Rila",
                            Description = @"The Monastery of Saint Ivan of Rila, better known as the Rila Monastery  is the largest and most famous Eastern Orthodox monastery in Bulga
ria. It is situated in the southwestern Rila Mountains, 117 km south of the capital Sofia in the deep valley of the Rilska River at an elevation of 1,147 m  above sea level, inside of Rila Monastery Nature Park. The monastery is named after its founder, the hermit Ivan of Rila, and houses around 60 monks.",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/tourist-visiting-monastery-of-saint-ivan-of-rila-kyustendil-region-picture-id958353710",
                            Country = "Bulgaria Rila",

                        },
                        new Landmark()
                        {
                            Name = "Bansko",
                            Description = @"Bansko is a town in southwestern Bulgaria, located at the foot of the Pirin Mountains at an elevation of 1200m above sea level. It is a ski res
ort.",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/houses-and-snow-mountains-panorama-in-bulgarian-ski-resort-bansko-picture-id635973512",
                            Country = "Bulgaria Pirin",

                        },
                        new Landmark()
                        {
                            Name = "Pamporovo",
                            Description = @"Pamporovo is a popular ski resort in Smolyan Province, southern Bulgaria. It is set amongst Norway spruce forests and is primarily visited du
ring the winter for skiing and snowboarding. It is also a popular tourist place in summer. The hub of Pamporovo comprises a number of hotels and bars. It is a family-friendly resort and suited for complete beginners and intermediates.",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/winter-landscape-of-rhodope-mountains-near-pamporovo-resort-from-picture-id999342042",
                            Country = "Bulgaria Rhodopes",

                        },
                        new Landmark()
                        {
                            Name = "Golden Bridges",
                            Description = @"Zlatnite Mostove is the largest stone river on Vitosha Mountain, Bulgaria. The feature is situated in the valley of Vladayska River, extending 2.
2 km, and up to 150 m wide, with several ‘tributary’ stone rivers. The stone river is ‘descending’ from elevation 1800 m above sea level in Boeritsa Chalet area to 1410 m at Zlatnite Mostove site. The lower extremity of the stone river is known as Zlatnite Mostove site, a popular tourist destination accessible from Sofia by road",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/golden-bridges-or-rocks-river-phenomenon-picture-id923345134",
                            Country = "Bulgaria Vitosha",
                        },
                        new Landmark()
                        {
                            Name = "Village Panchareevo",
                            Description = @"The village is located in the Pancharevo district of Sofia Municipality, Sofia District, 13 km from Sofia in the direction of the town of Samokov, along the Iskar River, on the southwestern slope of Lozenska Mountain.",
                            LandmarkPictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Pancharevo_1.JPG/1024px-Pancharevo_1.JPG",
                            Country = "Bulgaria Lozen Mountain",
                        },
                });


                if (!context.Landmarks.Any())
                {
                    context.Landmarks.AddRange(new List<Landmark>()
                    {
                        new Landmark()
                        {
                            Name = "Ski Zone Borovets",
                            Description = @"Borovets is the oldest Bulgarian winter resort with a history that dates back to 1896. Borovets was originally establis
hed at the end of the 19th Century as a hunting place for the Bulgarian Kings. Borovets gradually developed into a modern ski resort with hotels, restaurants, bars and a network of ski runs and lifts along the slopes of the Rila Mountains, providing for a whole range of winter sports. ",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/mountain-forest-arkhyz-picture-id500694572",
                            Country = "Bulgaria Rila",

                        },
                        new Landmark()
                        {
                            Name = "Monastery of Saint Ivan of Rila",
                            Description = @"The Monastery of Saint Ivan of Rila, better known as the Rila Monastery  is the largest and most famous Eastern Orthodox monastery in Bulga
ria. It is situated in the southwestern Rila Mountains, 117 km south of the capital Sofia in the deep valley of the Rilska River at an elevation of 1,147 m  above sea level, inside of Rila Monastery Nature Park. The monastery is named after its founder, the hermit Ivan of Rila, and houses around 60 monks.",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/tourist-visiting-monastery-of-saint-ivan-of-rila-kyustendil-region-picture-id958353710",
                            Country = "Bulgaria Rila",

                        },
                        new Landmark()
                        {
                            Name = "Bansko",
                            Description = @"Bansko is a town in southwestern Bulgaria, located at the foot of the Pirin Mountains at an elevation of 1200m above sea level. It is a ski res
ort.",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/houses-and-snow-mountains-panorama-in-bulgarian-ski-resort-bansko-picture-id635973512",
                            Country = "Bulgaria Pirin",

                        },
                        new Landmark()
                        {
                            Name = "Pamporovo",
                            Description = @"Pamporovo is a popular ski resort in Smolyan Province, southern Bulgaria. It is set amongst Norway spruce forests and is primarily visited du
ring the winter for skiing and snowboarding. It is also a popular tourist place in summer. The hub of Pamporovo comprises a number of hotels and bars. It is a family-friendly resort and suited for complete beginners and intermediates.",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/winter-landscape-of-rhodope-mountains-near-pamporovo-resort-from-picture-id999342042",
                            Country = "Bulgaria Rhodopes",

                        },
                        new Landmark()
                        {
                            Name = "Golden Bridges",
                            Description = @"Zlatnite Mostove is the largest stone river on Vitosha Mountain, Bulgaria. The feature is situated in the valley of Vladayska River, extending 2.
2 km, and up to 150 m wide, with several ‘tributary’ stone rivers. The stone river is ‘descending’ from elevation 1800 m above sea level in Boeritsa Chalet area to 1410 m at Zlatnite Mostove site. The lower extremity of the stone river is known as Zlatnite Mostove site, a popular tourist destination accessible from Sofia by road",
                            LandmarkPictureURL = "https://media.istockphoto.com/photos/golden-bridges-or-rocks-river-phenomenon-picture-id923345134",
                            Country = "Bulgaria Vitosha",
                        },
                        new Landmark()
                        {
                            Name = "Village Panchareevo",
                            Description = @"The village is located in the Pancharevo district of Sofia Municipality, Sofia District, 13 km from Sofia in the direction of the town of Samokov, along the Iskar River, on the southwestern slope of Lozenska Mountain.",
                            LandmarkPictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Pancharevo_1.JPG/1024px-Pancharevo_1.JPG",
                            Country = "Bulgaria Lozen Mountain",
                        },
                    });
                }

                Stack<Landmark> landmarkseedStackInitializer = new Stack<Landmark>(landmarkList);
                Stack<Landmark> landmarkseedListStackInitializer = new Stack<Landmark>(landmarkList);


                trackList.AddRange(new List<Track>()
                    {
                        new Track()
                        {
                            StartingPoint = "Samokov",
                            EndPoint = "Ski Zone Borovets",
                            Highlights = "Fast Life Organization",
                            StartDate = DateTime.ParseExact("11/11/2021","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("02/02/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Ski,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/group-skiing-picture-id1270325495",
                            Mountain  = mountainStackInitializer.Pop(),
                            Peak = peakStackInitializer.Pop(),
                            landmark = landmarkseedStackInitializer.Pop()
                        },
                        new Track()
                        {
                            StartingPoint = "Banderishka polyana",
                            EndPoint = "Bansko",
                            Highlights = "Bulgaria Ski Hodilay",
                            StartDate = DateTime.ParseExact("11/11/2021","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("12/02/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Ski,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/group-skiing-picture-id1270325495",
                            Mountain  = mountainStackInitializer.Pop(),
                            Peak = peakStackInitializer.Pop(),
                            landmark = landmarkseedStackInitializer.Pop()
                        },
                        new Track()
                        {
                            StartingPoint = "Malyovishki Lakes",
                            EndPoint = "Monastery of Saint Ivan of Rila",
                            Highlights = "Green Mountain Highlights",
                            StartDate = DateTime.ParseExact("01/04/2022","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("01/09/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Expedition,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/family-hiking-on-summer-vacation-in-colorado-mountains-picture-id1151466121",
                            Mountain  = mountainStackInitializer.Pop(),
                            Peak = peakStackInitializer.Pop(),
                            landmark = landmarkseedStackInitializer.Pop()
                        },
                        new Track()
                        {
                            StartingPoint = "Trojan Pass",
                            EndPoint = "Botev Peak",
                            Highlights = "Family DH track",
                            StartDate = DateTime.ParseExact("21/04/2021","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("04/06/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Downhill,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/professional-bike-rider-jumping-during-downhill-ride-on-his-bicycle-picture-id1301763194",
                            Mountain  = mountainStackInitializer.Pop(),
                            Peak = peakStackInitializer.Pop(),
                            landmark = landmarkseedStackInitializer.Pop()
                        },
                        new Track()
                        {
                            StartingPoint = "Panichishte village",
                            EndPoint = "Skakavitsa waterfall",
                            Highlights = "EarthTravellers",
                            StartDate = DateTime.ParseExact("27/04/2016","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("08/04/2016","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Hiking,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/lake-near-and-house-bezbog-bansko-in-bulgaria-picture-id656381290",
                            Mountain  = mountainStackInitializer.Pop(),
                            Peak = peakStackInitializer.Pop(),
                            landmark = landmarkseedStackInitializer.Pop()
                        },
                        new Track()
                        {
                            StartingPoint = "Golden Bridges",
                            EndPoint = "Cherni vruh",
                            Highlights = "EarthTravellers",
                            StartDate = DateTime.ParseExact("27/04/2016","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("08/04/2016","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Hiking,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/lake-near-and-house-bezbog-bansko-in-bulgaria-picture-id656381290",
                            Mountain  = mountainStackInitializer.Pop(),
                            Peak = peakStackInitializer.Pop(),
                            landmark = landmarkseedStackInitializer.Pop()
                        },
                    });

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
                            TrackCategory = TrackCategory.Ski,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/group-skiing-picture-id1270325495",
                            Mountain  = mountainListStackInitializer.Pop(),
                            Peak = peakListStackInitializer.Pop(),
                            landmark = landmarkseedListStackInitializer.Pop()
                        },
                        new Track()
                        {
                            StartingPoint = "Banderishka polyana",
                            EndPoint = "Bansko",
                            Highlights = "Bulgaria Ski Hodilay",
                            StartDate = DateTime.ParseExact("11/11/2021","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("12/02/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Ski,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/group-skiing-picture-id1270325495",
                            Mountain  = mountainListStackInitializer.Pop(),
                            Peak = peakListStackInitializer.Pop(),
                            landmark = landmarkseedListStackInitializer.Pop()
                        },
                        new Track()
                        {
                            StartingPoint = "Malyovishki Lakes",
                            EndPoint = "Monastery of Saint Ivan of Rila",
                            Highlights = "Green Mountain Highlights",
                            StartDate = DateTime.ParseExact("01/04/2022","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("01/09/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Expedition,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/family-hiking-on-summer-vacation-in-colorado-mountains-picture-id1151466121",
                            Mountain  = mountainListStackInitializer.Pop(),
                            Peak = peakListStackInitializer.Pop(),
                            landmark = landmarkseedListStackInitializer.Pop()
                        },
                        new Track()
                        {
                            StartingPoint = "Trojan Pass",
                            EndPoint = "Botev Peak",
                            Highlights = "Family DH track",
                            StartDate = DateTime.ParseExact("21/04/2021","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("04/06/2022","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Downhill,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/professional-bike-rider-jumping-during-downhill-ride-on-his-bicycle-picture-id1301763194",
                            Mountain  = mountainListStackInitializer.Pop(),
                            Peak = peakListStackInitializer.Pop(),
                            landmark = landmarkseedListStackInitializer.Pop(),


                        },
                        new Track()
                        {

                            StartingPoint = "Panichishte village",
                            EndPoint = "Skakavitsa waterfall",
                            Highlights = "EarthTravellers",
                            StartDate = DateTime.ParseExact("27/04/2016","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("08/04/2016","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Hiking,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/lake-near-and-house-bezbog-bansko-in-bulgaria-picture-id656381290",
                            Mountain  = mountainListStackInitializer.Pop(),
                            Peak = peakListStackInitializer.Pop(),
                            landmark = landmarkseedListStackInitializer.Pop()
                        },
                        new Track()
                        {
                            StartingPoint = "Golden Bridges",
                            EndPoint = "Cherni vruh",
                            Highlights = "EarthTravellers",
                            StartDate = DateTime.ParseExact("27/04/2016","dd/MM/yyyy", null),
                            EndDate = DateTime.ParseExact("08/04/2016","dd/MM/yyyy", null),
                            TrackCategory = TrackCategory.Hiking,
                            TrackCateogryURL = "https://media.istockphoto.com/photos/lake-near-and-house-bezbog-bansko-in-bulgaria-picture-id656381290",
                            Mountain  = mountainListStackInitializer.Pop(),
                            Peak = peakListStackInitializer.Pop(),
                            landmark = landmarkseedListStackInitializer.Pop()
                        },
                    });
                }
                context.SaveChanges();
                if (!context.Peaks_Mountains.Any())
                {
                    context.Peaks_Mountains.AddRange(new List<Peaks_Mountains>()
                            {
                                new Peaks_Mountains()
                                {
                                    PeakId = 1,
                                    MountainId = 1
                                },
                                 new Peaks_Mountains()
                                {
                                    PeakId = 2,
                                    MountainId = 2
                                },
                                  new Peaks_Mountains()
                                {
                                    PeakId = 3,
                                    MountainId = 3
                                },
                                   new Peaks_Mountains()
                                {
                                    PeakId = 4,
                                    MountainId = 4
                                },
                                     new Peaks_Mountains()
                                {
                                    PeakId = 5,
                                    MountainId = 5
                                },
                                       new Peaks_Mountains()
                                {
                                    PeakId = 6,
                                    MountainId = 6
                                },

                            });
                }
                context.SaveChanges();
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
                                    PeakId = 2
                                },
                                  new Tracks_Peaks()
                                {
                                    TrackId = 3,
                                    PeakId = 3
                                },
                                   new Tracks_Peaks()
                                {
                                    TrackId = 4,
                                    PeakId = 4
                                },
                                    new Tracks_Peaks()
                                {
                                    TrackId = 5,
                                    PeakId = 5
                                },
                                     new Tracks_Peaks()
                                {
                                    TrackId = 6,
                                    PeakId = 6
                                },

                            });
                };
                context.SaveChanges();
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
                                    TrackId = 3,
                                    LandmarkId = 3
                                },
                                   new Tracks_Landmarks()
                                {
                                    TrackId = 3,
                                    LandmarkId = 4
                                },

                            });
                }
                context.SaveChanges();
                if (!context.Tracks_Mountains.Any())
                {
                    context.Tracks_Mountains.AddRange(new List<Tracks_Mountains>()
                            {
                                new Tracks_Mountains()
                                {
                                    TrackId = 1,
                                    MountainId = 1
                                },
                                 new Tracks_Mountains()
                                {
                                    TrackId = 2,
                                    MountainId = 2
                                },
                                  new Tracks_Mountains()
                                {
                                    TrackId = 3,
                                    MountainId = 3
                                },
                                   new Tracks_Mountains()
                                {
                                    TrackId = 4,
                                    MountainId = 4
                                },
                                    new Tracks_Mountains()
                                {
                                    TrackId = 5,
                                    MountainId = 5
                                },
                                     new Tracks_Mountains()
                                {
                                    TrackId = 6,
                                    MountainId = 6
                                },

                            });
                }
                context.SaveChanges();
            }

        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                {
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string admiUserEmail = "admin@mountains.com";
                var adminUser = await userManager.FindByEmailAsync(admiUserEmail);

                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = admiUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@mountains.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);

                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}



