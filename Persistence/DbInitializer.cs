using System;
using Domain;

namespace Persistence;

    public class DbInitializer
    {        
        public static async Task SeedData(AppDbContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                    Latitude = 51.5074,
                    Longitude = -0.1278
                },
                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                    Latitude = 48.8566,
                    Longitude = 2.3522
                },
                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Activity in 1 month",
                    Category = "music",
                    City = "New York",
                    Venue = "Madison Square Garden",
                    Latitude = 40.7128,
                    Longitude = -74.0060
                },
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Activity in 2 months",
                    Category = "food",
                    City = "Rome",
                    Venue = "Trattoria da Enzo",
                    Latitude = 41.9028,
                    Longitude = 12.4964
                }
            };

            context.Activities.AddRange(activities);
            await context.SaveChangesAsync();
        }
    }