using AutoCompleteSearch.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoCompleteSearch.Data
{
    public class YourDbContext: DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
