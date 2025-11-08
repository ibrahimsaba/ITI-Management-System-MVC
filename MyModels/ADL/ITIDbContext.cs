using Microsoft.EntityFrameworkCore;
using MyModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModels.ADL
{
    public class ITIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        //public ITIDbContext()
        //{

        //}

        public ITIDbContext(DbContextOptions<ITIDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>(s =>
            {
                s.HasKey(s => new { s.StdId, s.CrsId });
            });
            modelBuilder.Entity<Department>(d =>
            {
                d.HasData(
                new Department { DeptId = 100, DeptName = ".Net", Capacity = 100 },
                new Department { DeptId = 200, DeptName = "FrontEnd", Capacity = 200 },
                new Department { DeptId = 300, DeptName = "OS", Capacity = 50 },
                new Department { DeptId = 400, DeptName = "Cyper security", Capacity = 40 });
            });
            modelBuilder.Entity<Course>(d =>
            {
                d.HasData(
                new Course { CrsId = 1, CrsName = "C#", CrsDUeation = 100 },
                new Course { CrsId = 2, CrsName = "HTML", CrsDUeation = 200 },
                new Course { CrsId = 3, CrsName = "ASP.Net", CrsDUeation = 50 },
                new Course { CrsId = 4, CrsName = "Wep Api", CrsDUeation = 40 });
            });

        }
    }
}
