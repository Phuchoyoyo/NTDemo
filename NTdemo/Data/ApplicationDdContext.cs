using Microsoft.EntityFrameworkCore;
using NTdemo.Models;

namespace NTdemo.Data
{
    public class ApplicationDdContext : DbContext
	{
		public ApplicationDdContext(DbContextOptions<ApplicationDdContext> options) : base(options)
		{
		}
		public DbSet<Category> Categories { get; set; }
	}
}

