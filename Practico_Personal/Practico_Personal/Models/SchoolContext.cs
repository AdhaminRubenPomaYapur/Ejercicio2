using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Practico_Personal.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
                modelBuilder.Entity<Course>()
                    .HasMany(c => c.Instructors).WithMany(i => i.Courses)
                    .Map(t => t.MapLeftKey("CourseID")
                        .MapRightKey("InstructorID")
                        .ToTable("CourseInstructor"));
        }
    }
}