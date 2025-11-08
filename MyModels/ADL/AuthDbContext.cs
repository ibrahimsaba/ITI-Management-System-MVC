using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyModels.ADL
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var adminId = Guid.NewGuid().ToString();
            var studentId = Guid.NewGuid().ToString();
            var instructorId = Guid.NewGuid().ToString();
            var userId = Guid.NewGuid().ToString();
            var roles = new List<IdentityRole> { 
                new IdentityRole {Id = adminId, Name="Admin", NormalizedName="ADMIN"},
                new IdentityRole {Id = studentId, Name="Student", NormalizedName="STUDENT"},
                new IdentityRole {Id = instructorId, Name="Instructor", NormalizedName="INSTRUCTOR"},
            };
            var user = new IdentityUser
            {
                Id = userId,
                UserName = "admin@gmail.gov",
                NormalizedUserName = "admin@gmail.gov".ToUpper(),
                Email = "admin@gmail.gov",
                NormalizedEmail = "admin@gmail.gov".ToUpper()
            };
            user.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(user, "Admin@123");
            builder.Entity<IdentityRole>(s =>
            {
                s.HasData(roles);
            });
            builder.Entity<IdentityUser>(u=>
            {
                u.HasData(user);
            });
            builder.Entity<IdentityUserRole<string>>(s=>
            {
                s.HasData(new IdentityUserRole<String>
                {
                    RoleId = adminId,
                    UserId = userId,
                });
            });
            base.OnModelCreating(builder);
        }
    }
}
