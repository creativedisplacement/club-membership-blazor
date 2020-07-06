using ClubMembership.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubMembership.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
    }
}