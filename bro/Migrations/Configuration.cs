namespace bro.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;
    using Notifications;

    internal sealed class Configuration : DbMigrationsConfiguration<GamePulseDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(GamePulseDBContext context)
        {
            try
            {
                // Seed data
                context.Users.AddOrUpdate(
                    u => u.Email,
                    new User { Name = "John Doe", Email = "john.doe@example.com", Password = "Password123" },
                    new User { Name = "Jane Smith", Email = "jane.smith@example.com", Password = "SecurePassword123" }
                );

                // Save changes to the database
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Log validation errors
                foreach (var entityError in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityError.ValidationErrors)
                    {
                        Console.WriteLine($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                    }
                }
            }
        }


    }
}
