using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DepartmentContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }
}