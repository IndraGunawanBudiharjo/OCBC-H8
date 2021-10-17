using Microsoft.EntityFrameworkCore;
using Movies.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Movies.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<MovieData> Movies {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}