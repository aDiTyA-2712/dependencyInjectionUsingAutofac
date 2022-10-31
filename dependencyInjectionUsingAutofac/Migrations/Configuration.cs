namespace dependencyInjectionUsingAutofac.Migrations
{
    using dependencyInjectionUsingAutofac.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<dependencyInjectionUsingAutofacContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(dependencyInjectionUsingAutofacContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(
                p => p.Username,
                new User
                {
                    Username = "Kimo",
                    Password = "123",
                    FirstName = "Maioza",
                    LastName = "Zaki",
                    About = "Hiiiii",
                    RememberMe = true,
                    Gender="Male",
                });


        }
    }
}
