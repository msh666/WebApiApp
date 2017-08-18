using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DepartmentDbInitializer : CreateDatabaseIfNotExists<DepartmentContext>
    {
        protected override void Seed(DepartmentContext db)
        {
            db.Departments.Add(new Department { Title = "IT Dep" });
            db.Departments.Add(new Department { Title = "Marketing" });
            db.Departments.Add(new Department { Title = "RND" });

            base.Seed(db);
        }
    }
}