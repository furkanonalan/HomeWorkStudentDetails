using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails.Models
{
	public class StudentStoreContext : DbContext

	{
		public StudentStoreContext(DbContextOptions<StudentStoreContext> options) : base(options)
		{

		}
		public DbSet<Student> Students { get; set; }

	}
}