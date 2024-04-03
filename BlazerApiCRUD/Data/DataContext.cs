using BlazorApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApi.Data
{

    public class DataContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    }
}
