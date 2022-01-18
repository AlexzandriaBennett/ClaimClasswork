namespace RealOfficialLab3.Models
{
    public class StudentAndCourseRelationship
    {

        //this is a new table. Using flat relationship to establish a relationship between student and courses and course and students
        public int Id { get; set; }

        public int StudentNumber { get; set; }

        public int CourseNumber { get; set; }   
    }
}
