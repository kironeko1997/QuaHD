using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuaHD.Core.Entities.Authorization;
using QuaHD.Core.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuaHD.EntityFramework
{
    public class QuaHDContext : IdentityDbContext<User, Role, int>
    {
        public QuaHDContext(DbContextOptions<QuaHDContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<LessonQuiz> LessonQuizzes { get; set; }

        public DbSet<LessonQuizChoice> LessonQuizChoices { get; set; }
    }
}
