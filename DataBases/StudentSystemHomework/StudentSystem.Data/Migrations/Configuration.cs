namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Model;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            Student student;
            Course course = new Course { Description = "JSApp" };
            
            for (int i = 0; i < 50; i++)
            {
                student = new Student { Name = "Pesho" + i, Number = "123" + i };
                course.Students.Add(student);
            }

            context.Courses.Add(course);
            context.SaveChanges();
        }
    }
}
