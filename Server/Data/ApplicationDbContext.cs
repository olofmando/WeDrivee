using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WeDrivee.Server.Models;

namespace WeDrivee.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<CarModel> Cars { get; set; }
        public DbSet<BookingModel> Bookings { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CarModel>().HasData(new CarModel()
            {
                Id = 1,
                Name = "Volvo",
                DailyPrice = 300

            }) ;
            builder.Entity<CarModel>().HasData(new CarModel()
            {
                Id = 2,
                Name = "Saab",
                DailyPrice = 200

            });
            builder.Entity<CarModel>().HasData(new CarModel()
            {
                Id = 3,
                Name = "Fiat",
                DailyPrice = 400

            });
        }
    }
}