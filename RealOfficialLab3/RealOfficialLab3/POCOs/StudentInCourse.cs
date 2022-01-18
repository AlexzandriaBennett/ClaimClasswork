using RealOfficialLab3.Models;

namespace RealOfficialLab3.POCOs
{
    public class StudentInCourse
    {

        //this class helps build the flat relationship between student and course

        public List<Student> Students { get; set; }

        public Course Course { get; set; }  
    }
}
