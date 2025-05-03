using Microsoft.EntityFrameworkCore;
using WatchApi.Models;


namespace WatchAPI.Data

public class WatchContext : DbContext
{
    public WatchContext(DbContextOptions<WatchContext> options) : base(options) { }

    public DbSet<Watch> Watches => Set<Watch>();
}