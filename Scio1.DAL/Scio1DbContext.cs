using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Scio1.DAL.Entities;
using Scio1.WebApp.Data;

namespace Scio1.DAL
{
    public class Scio1DbContext(DbContextOptions<Scio1DbContext> options) : IdentityDbContext<MeetingUser>(options)
    {
        public DbSet<MeetingEntity> MeetingModel { get; set; } = default!;
    }
}
