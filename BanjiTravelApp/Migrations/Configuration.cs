namespace BanjiTravelApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BanjiTravelApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BanjiTravelApp.Context.TravelAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BanjiTravelApp.Context.TravelAppContext context)
        {
            context.Profiles.AddOrUpdate(
                p => p.ProfileId,
                new Profile
                {
                    ProfileId = 1,
                    DisplayName = "Dave",
                    Username = "dave",
                    EmailAddress = "dave.ton@example.com"
                }
            );
            context.Profiles.AddOrUpdate(
                p => p.ProfileId,
                new Profile
                {
                    ProfileId = 2,
                    DisplayName = "Shafiq",
                    Username = "shafiq",
                    EmailAddress = "shafiq.jetha@example.com"
                }
            );
            context.Markers.AddOrUpdate(
                m => m.MarkerId,
                new Marker
                {
                    MarkerId = 1,
                    Name = "Home",
                    Latitude = 0,
                    Longitude = 0,
                    ProfileId = 1,
                    Date = DateTime.Now
                }
            );

            //context.Profiles.AddOrUpdate(
            //    p => p.ProfileId,
            //    new Profile { ProfileId = 1, DisplayName = "Shafiq" }
            //    );
            //context.Markers.AddOrUpdate(
            //    m => m.MarkerId,
            //    new Marker { MarkerId = 1, Latitude = 0, Longitude = 0 }
            //    );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
