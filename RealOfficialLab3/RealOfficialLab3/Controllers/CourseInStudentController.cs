using Microsoft.AspNetCore.Mvc;
using RealOfficialLab3.Data;
using RealOfficialLab3.POCOs;

namespace RealOfficialLab3.Controllers
{
    public class CourseInStudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseInStudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {


            var response = new CourseInStudent();
            response.Courses = new List<Models.Course>();

            // as of now just trying to show the first course

            var studentNumber = 1;

            response.Student = _context.Student.First(x => x.Id == studentNumber);

            var listOfCoursesForThisStudent = _context.StudentAndCourseRelationship.Select(x => x).Where(x => x.StudentNumber == studentNumber).ToList();

            foreach (var course in listOfCoursesForThisStudent)
            {
                var tempCourse = _context.Course.First(x => x.Id == course.CourseNumber);

                response.Courses.Add(tempCourse);
            }

            //trying to return a single course with all the courses in it
            return View(response);
        }
    }
}
