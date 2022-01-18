using Microsoft.AspNetCore.Mvc;
using RealOfficialLab3.Data;
using RealOfficialLab3.POCOs;

namespace RealOfficialLab3.Controllers
{
    public class StudentInCourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentInCourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            var response = new StudentInCourse();
            response.Students = new List<Models.Student>();

            // as of now just trying to show the first course

            var CourseNumber = 1;

            response.Course = _context.Course.First(x => x.Id == CourseNumber);

            var listOfStudentsInThisCourse = _context.StudentAndCourseRelationship.Select(x => x).Where(x => x.CourseNumber == CourseNumber).ToList();

            foreach(var student in listOfStudentsInThisCourse)
            {
                var tempStudent = _context.Student.First(x => x.Id == student.StudentNumber);

                response.Students.Add(tempStudent);
            }

            //trying to return a single course with all the students in it
            return View(response);
        }
    }
}
