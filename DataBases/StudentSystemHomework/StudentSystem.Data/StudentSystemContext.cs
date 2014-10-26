﻿namespace StudentSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using StudentSystem.Model;

    public class StudentSystemContext : DbContext 
    {
        public StudentSystemContext()
        : base("StudentSystemDb")
        { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> Homeworks { get; set; }
    }
}
