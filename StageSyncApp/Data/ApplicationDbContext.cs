using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StageSyncApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StageSyncApp.Models.Artist> Artist { get; set; } = default!;
        public DbSet<StageSyncApp.Models.Booking> Booking { get; set; } = default!;
    }
}
