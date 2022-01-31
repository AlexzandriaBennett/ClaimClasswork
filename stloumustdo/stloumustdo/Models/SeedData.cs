using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using stloumustdo.Data;
using System;
using System.Linq;


namespace stloumustdo.Models
{
    public class SeedData
    {


        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new stloumustdoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<stloumustdoContext>>()))
            {
                // Look for any movies.
                if (context.Restaurants.Any())
                {
                    return;   // DB has been seeded
                }

                context.Restaurants.AddRange(
                    new Restaurants
                    {
                        RestaurantName = "The Lucky Accomplice",
                        RestaurantType = "American",
                        PriceRange = "$$",
                        Neighborhood = "Fox Park",
                        ResturauntAddress = "2501 S Jefferson Ave, St. Louis, MO 63104",
                        WebsiteUrl = "https://www.theluckyaccomplice.com/"

                    },

                    new Restaurants
                    {
                        RestaurantName = "Three Sixty",
                        RestaurantType = "American",
                        PriceRange = "$$",
                        Neighborhood = "Downtown",
                        ResturauntAddress = "1 S Broadway St, St. Louis, MO 63102",
                        WebsiteUrl = "https://www.360-stl.com/"
                    },

                    new Restaurants
                    {
                        RestaurantName = "Mama’s On The Hill",
                        RestaurantType = "Italian",
                        PriceRange = "$$",
                        Neighborhood = "The Hill",
                        ResturauntAddress = "2132 Edwards St, St. Louis, MO 63110",
                        WebsiteUrl = "https://www.mamasonthehill.com/"
                    },

                    new Restaurants
                    {
                        RestaurantName = "Fork & Stix",
                        RestaurantType = "Northern Thai",
                        PriceRange = "$",
                        Neighborhood = "The Loop",
                        ResturauntAddress = "549 Rosedale Ave, St. Louis, MO 63112",
                        WebsiteUrl = "https://forknstix.com/"
                    }
                );

                if (context.Cafes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cafes.AddRange(
                    new Cafe
                    {
                        CafeName = "Coma Coffee Roasters",
                        Neighborhood = "Richmond Heights",
                        Address = "1034 S Brentwood Blvd, Richmond Heights, MO 63117",
                        WebsiteUrl = "https://www.comacoffee.com/"

                    },
                    new Cafe
                    {
                        CafeName = "Nathaniel Reid Bakery",
                        Neighborhood = "Kirkwood",
                        Address = "11243 Manchester Rd, Kirkwood, MO 63122",
                        WebsiteUrl = "https://www.nrbakery.com/"

                    },
                    new Cafe
                    {
                        CafeName = "Mauhaus Cat Cafe",
                        Neighborhood = "Maplewood",
                        Address = "3101 Sutton Blvd, Maplewood, MO 63143",
                        WebsiteUrl = "https://mauhauscafe.com/"

                    },
                    new Cafe
                    {
                        CafeName = "Have A Cow Cattle Co.",
                        Neighborhood = "Lafayette Square",
                        Address = "2742 Lafayette Ave, St. Louis, MO 63104",
                        WebsiteUrl = "https://www.haveacow.farm/urban-farm-store"

                    }
                );

                if (context.LocalAttractions.Any())
                {
                    return;   // DB has been seeded
                }

                context.LocalAttractions.AddRange(
                    new LocalAttraction
                    {
                        AttractionName = "City Museum",
                        Neighborhood = "Downtown",
                        Address = "750 N 16th St, St. Louis, MO 63103",
                        AttractionUrl = "https://www.citymuseum.org/"

                    },

                     new LocalAttraction
                     {
                         AttractionName = "The Gateway Arch",
                         Neighborhood = "Downtown",
                         Address = "11 North 4th Street, St. Louis, MO 63102",
                         AttractionUrl = "https://www.gatewayarch.com/"

                     },

                      new LocalAttraction
                      {
                          AttractionName = "The Wheel",
                          Neighborhood = "Downtown",
                          Address = "1820 Market Street, St. Louis, Missouri - MO 63103",
                          AttractionUrl = "https://www.thestlouiswheel.com/"

                      },

                       new LocalAttraction
                       {
                           AttractionName = "Laumeier Sculpture Park",
                           Neighborhood = "Sappington",
                           Address = "12580 Rott Rd, Sappington, MO 63127",
                           AttractionUrl = "https://www.laumeiersculpturepark.org/"

                       }
                );

                if (context.StatewideOutdoors.Any())
                {
                    return;   // DB has been seeded
                }

                context.StatewideOutdoors.AddRange(
                    new StatewideOutdoors
                    {
                        OutdoorName = "Lone Elk Park",
                        DistanceFromSTL = "30 Minutes",
                        Address = "1 Lone Elk Park Rd, Valley Park, MO 63088",
                        OutdoorUrl = "https://stlouiscountymo.gov/st-louis-county-departments/parks/places/lone-elk-park/"

                    },
                    new StatewideOutdoors
                    {
                        OutdoorName = "Weldon Spring Lewis & Clark Hiking Trail",
                        DistanceFromSTL = "40 Minutes",
                        Address = "7394-7398 MO-94, St Charles, MO 63304",
                        OutdoorUrl = "https://www.alltrails.com/trail/us/missouri/lewis-and-clark-trail-and-lewis-trail-loop"

                    },
                    new StatewideOutdoors
                    {
                        OutdoorName = "Johnson's Shut-Ins State Park",
                        DistanceFromSTL = "2 Hours",
                        Address = "148 Taum Sauk Trail, Middle Brook, MO 63656",
                        OutdoorUrl = "https://mostateparks.com/park/johnsons-shut-ins-state-park"

                    },
                    new StatewideOutdoors
                    {
                        OutdoorName = "Onondaga Cave State Park",
                        DistanceFromSTL = "1.5 Hours",
                        Address = "7556 Hwy H, Leasburg, MO 65535",
                        OutdoorUrl = "https://mostateparks.com/park/onondaga-cave-state-park"

                    }

                );

                context.SaveChanges();
            }     
        }
    }
}
