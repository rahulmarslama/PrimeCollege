using System.ComponentModel;

namespace PrimeCollege.Models
{
    public class Student
    {
        public int ID { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
