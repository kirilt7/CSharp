using System;
using System.Data.Entity;
using System.Linq;
using StudentSystem.Data;
using StudentSystem.Data.Migrations;
using StudentSystem.Model;

namespace StudentSystem.Client
{
    class Program
    {
        static void Main()
        {   
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());
            var db = new StudentSystemContext();
            db.Students.Add(new Student { Name = "gosho", Number = "123456" });
            db.SaveChanges();
        }
    }
}
