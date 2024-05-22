using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppUserContext : DbContext
{
    public AppUserContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<AppUser> Users { get; set; }
}
