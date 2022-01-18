using RealOfficialLab3.Models;

namespace RealOfficialLab3.POCOs
{
    public class CourseInStudent
    {

        public Student Student { get; set; }

        public List<Course> Courses { get; set; }
    }
}
