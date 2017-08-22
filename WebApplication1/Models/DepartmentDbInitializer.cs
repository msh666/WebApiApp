using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DepartmentDbInitializer : DropCreateDatabaseAlways<DepartmentContext>
    {
        protected override void Seed(DepartmentContext db)
        {
            db.Departments.Add(new Department { Title = "Finance" });
            db.Departments.Add(new Department { Title = "Procurement" });
            db.Departments.Add(new Department { Title = "Legal & Contracts" });
            db.Departments.Add(new Department { Title = "Factory Management" });
            db.Departments.Add(new Department { Title = "Design" });
            db.Departments.Add(new Department { Title = "R & D" });
            db.Departments.Add(new Department { Title = "International Commercial" });
            db.Departments.Add(new Department { Title = "Local Suppliers" });
            db.Departments.Add(new Department { Title = "Local Product Sales" });
            db.Departments.Add(new Department { Title = "Overseas Product Sales" });
            db.Departments.Add(new Department { Title = "Marketing and Public Relations" });

            base.Seed(db);
        }
    }
}