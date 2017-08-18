using System.Data.Entity;

namespace WebApplication1.Models
{
    public class UserDbInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Users.Add(new User { UserName = "Иванов", DepartmentId = 1});
            db.Users.Add(new User { UserName = "Петров", DepartmentId = 1});
            db.Users.Add(new User { UserName = "Сидоров" , DepartmentId = 2});

            base.Seed(db);
        }
    }
}