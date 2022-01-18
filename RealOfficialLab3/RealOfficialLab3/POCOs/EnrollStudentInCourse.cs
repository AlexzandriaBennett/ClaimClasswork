using Microsoft.AspNetCore.Mvc.Rendering;

namespace RealOfficialLab3.POCOs
{
    public class EnrollStudentInCourse
    {

       public StudentInCourse StudentInCourse { get; set; } 

       public List<SelectListItem> ListOfStudents { get; set; }
    }
}
