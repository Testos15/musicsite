using Microsoft.EntityFrameworkCore;

namespace MusicSite.Infrastructure;

public class MusicSiteDbContext : DbContext
{
    public MusicSiteDbContext(DbContextOptions<MusicSiteDbContext> options)
        : base(options) { }
}
