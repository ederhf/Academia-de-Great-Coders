namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using OdeToFood.Models;
    using System.Collections.Generic;
    using WebMatrix.WebData;
    using System.Web.Security;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
            context.Restaurants
                .AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Sabatino", City = "Baltimore", Country = "USA" },
                new Restaurant { Name = "Gordão Lanches", City = "Valinhos", Country = "Brazil" },
                new Restaurant
                {
                    Name = "Smaka",
                    City = "Gothenburg",
                    Country = "Sweden",
                    Reviews =
                        new List<RestaurantReview> {
                            new RestaurantReview { Rating = 9, Body = "Great Food!", ReviewerName = "Éder" }
                        }
                });
            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Restaurant { Name = i.ToString(), City = "Far Far Away", Country = "USA" });
            }

            SeedMembership();

        }

        private void SeedMembership()
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", 
                "UserProfile", "UserId", "UserName", autoCreateTables: true);

            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if (!roles.RoleExists("Admin"))
            {
                roles.CreateRole("Admin");                
            }
            if (membership.GetUser("Teste", false) == null)
            {
                membership.CreateUserAndAccount("Teste", "123456");
            }
            if (!roles.GetRolesForUser("Teste").Contains("Admin"))
            {
                roles.AddUsersToRoles(new[] { "Teste" }, new[] { "admin" });                
            }
            
        }
    }
}
