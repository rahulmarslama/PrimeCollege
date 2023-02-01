using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeCollege.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public List<Enrollment> Enrollments { get; set; }
    }
}
