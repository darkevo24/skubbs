using Microsoft.EntityFrameworkCore;
using Skubbs_Test.Models;

namespace Skubbs_Test.Data
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }
	}
}
