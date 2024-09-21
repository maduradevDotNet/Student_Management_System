namespace StudentManagementSystem.Models
{
    public class Student
    {
        // Unique Identifier for each student
        public int StudentId { get; set; }

        // Personal Information
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        // Contact Information
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Address Information
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        // Academic Information
        public string Course { get; set; }
        public int Year { get; set; }
        public double GPA { get; set; }

        // Enrollment Status
        public bool IsActive { get; set; } = true;


    }
}
