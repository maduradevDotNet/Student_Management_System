
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Student>().HasData(
        new Student
        {
            StudentId = 1,
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = new DateTime(2000, 5, 15),
            Gender = "Male",
            Email = "john.doe@example.com",
            PhoneNumber = "123-456-7890",
            Address = "123 Main St",
            City = "Springfield",
            State = "IL",
            PostalCode = "62704",
            Course = "Computer Science",
            Year = 3,
            GPA = 3.75,
            IsActive = true
        },
        new Student
        {
            StudentId = 2,
            FirstName = "Jane",
            LastName = "Smith",
            DateOfBirth = new DateTime(1999, 10, 22),
            Gender = "Female",
            Email = "jane.smith@example.com",
            PhoneNumber = "987-654-3210",
            Address = "456 Oak Ave",
            City = "Rivertown",
            State = "CA",
            PostalCode = "90210",
            Course = "Mathematics",
            Year = 4,
            GPA = 3.90,
            IsActive = true
        }
    );
}

    }
}
