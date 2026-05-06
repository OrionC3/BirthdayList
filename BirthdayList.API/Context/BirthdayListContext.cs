using BirthdayList.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BirthdayList.API.Context
{
    public class BirthdayListContext : DbContext
    {
        public BirthdayListContext(DbContextOptions<BirthdayListContext> options) : base(options) { }

        public DbSet<Gift> Gift => Set<Gift>();
        public DbSet<Photo> Photo => Set<Photo>();
    }
}
