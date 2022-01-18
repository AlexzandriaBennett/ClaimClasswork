#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealOfficialLab3.Data;
using RealOfficialLab3.Models;
using RealOfficialLab3.POCOs;

namespace RealOfficialLab3.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Course.ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StaffId")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }



        //GET: Courses/Enroll
        public async Task<IActionResult> Enroll(int? id)
        {
            // not doing the null check
            // get list of all students
            // get course name  
            // return list of all students and course information 

            var response = new StudentInCourse();
            response.Course = await _context.Course.FindAsync(id);

            response.Students = await _context.Student.ToListAsync();
            // TODO: some of these students may have already enrolled. Figure out how to remove them from the list

            //   public List<SelectListItem> Options { get; set; }
            //public void OnGet()
            //{
            //    Options = context.Authors.Select(a =>
            //                                  new SelectListItem
            //                                  {
            //                                      Value = a.AuthorId.ToString(),
            //                                      Text = a.Name
            //                                  }).ToList();
            //}


            List<SelectListItem> ListOfStudents = new List<SelectListItem>();

            ListOfStudents = response.Students.Select(x => new SelectListItem
            {

                Value = x.Id.ToString(),
                Text = x.Name,

            }).ToList();

            var response2 = new EnrollStudentInCourse();
            response2.StudentInCourse = response;
            response2.ListOfStudents = ListOfStudents;


            return View(response2);

        }





        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }


        // POST: Courses/Enroll
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Enroll(int id, [Bind("courseId,studentId")] EnrollSubmit enroll)
        {
            var temprelationship = new StudentAndCourseRelationship();

            temprelationship.CourseNumber = enroll.courseId;
            temprelationship.StudentNumber = enroll.studentId;

            //TODO: if the student and the course are already in the table, dont add 
            // as of now might end up adding same student/course again and again

            await _context.StudentAndCourseRelationship.AddAsync(temprelationship);
            await _context.SaveChangesAsync();

            //TODO: stay on page to add more students or click return to list
            return RedirectToAction(nameof(Index));
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StaffId")] Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Course.FindAsync(id);
            _context.Course.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.Id == id);
        }
    }
}
