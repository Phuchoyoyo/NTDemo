using System;
using Microsoft.EntityFrameworkCore;

namespace NTdemo.Data
{
	public class ApplicationDdContext : DbContext
	{
		public ApplicationDdContext(DbContextOptions<ApplicationDdContext> options) : base(options)
		{
		}

	}
}

