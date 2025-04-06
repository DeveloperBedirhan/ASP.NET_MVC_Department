using Microsoft.EntityFrameworkCore;

namespace CoreDepartment.Models
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-TK6RUVA; " +
				"database=corepersonal; integrated security=true; TrustServerCertificate=True");
		}

		public DbSet<Department> Departments { get; set; }
		public DbSet<Personal> Personals { get; set; }
	}
}
