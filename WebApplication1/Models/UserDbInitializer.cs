using System.Data.Entity;

namespace WebApplication1.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Users.Add(new User { UserName = "FearLeSS", DepartmentId = 10});
            db.Users.Add(new User { UserName = "Slug-em-dog", DepartmentId = 5});
            db.Users.Add(new User { UserName = "CodeExia", DepartmentId = 9});
            db.Users.Add(new User { UserName = "Danqqqqq", DepartmentId = 7});
            db.Users.Add(new User { UserName = "Flotsams54", DepartmentId = 1});
            db.Users.Add(new User { UserName = "RZR", DepartmentId = 4});
            db.Users.Add(new User { UserName = "Toxic-oxide", DepartmentId = 6});
            db.Users.Add(new User { UserName = "DeathDancer", DepartmentId = 9});
            db.Users.Add(new User { UserName = "Sw00sh", DepartmentId = 3});
            db.Users.Add(new User {UserName = "LyRz", DepartmentId = 11});

            base.Seed(db);
        }
    }
}