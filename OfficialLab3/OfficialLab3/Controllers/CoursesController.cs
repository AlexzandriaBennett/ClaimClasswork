#nullable disable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficialLab3.Data;
using OfficialLab3.Models;

namespace OfficialLab3.Controllers
{
    public class CoursesController : Controller
    {
        private readonly OfficialLab3Context _context;

        public CoursesController(OfficialLab3Context context)
        {
            _context = context;
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            var officialLab3Context = _context.Course.Include(c => c.Teacher).Include(s => s.Students);
            return View(await officialLab3Context.ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .Include(c => c.Teacher)
                .Include(s => s.Students)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["Specialty"] = new SelectList(_context.Set<Teacher>(), "Specialty", "Specialty");
            
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,TeacherId")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TeacherId"] = new SelectList(_context.Set<Teacher>(), "StaffId", "StaffId", course.TeacherId);
            return View(course);
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
            ViewData["TeacherId"] = new SelectList(_context.Set<Teacher>(), "StaffId", "StaffId", course.TeacherId);
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,TeacherId")] Course course)
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
            ViewData["TeacherId"] = new SelectList(_context.Set<Teacher>(), "StaffId", "StaffId", course.TeacherId);
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
                .Include(c => c.Teacher)
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











        // GET: Courses/Enroll/
        public async Task<IActionResult> Enroll(int? id)
        {


            //course.Students = await _context.Student.ToListAsync();

            //List<SelectListItem> ListOfStudents = new List<SelectListItem>();

            //ListOfStudents = course.Students.Select(x => new SelectListItem
            //{

            //    Value = x.Id.ToString(),
            //    Text = x.Name,

            //}).ToList();

            //ViewData["Name"] =  _context.Student.Select(x => new SelectListItem
            //{

            //    Value = x.Id.ToString(),
            //    Text = x.Name,

            //}).ToList();


            var course = new Course();
            course.Students = new List<Student>();
            course.Students.Select(x => new SelectListItem
            {

                Value = x.Id.ToString(),
                Text = x.Name,

            }).ToList();


            //ViewData["Name"] = new SelectList(_context.Set<Student>(), "Name", "Name");
            return View(course);
        }

       // POST: Courses/Enroll/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Enroll(int id,[Bind("Id", "Name")] Course course)
        public async Task<IActionResult> Enroll(int id, int studentId, [Bind("Id, StudentId, Name, Students")] Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }


            var course1 = await _context.Course.FindAsync(id);
            var student1 = await _context.Student.FindAsync(studentId);

            //var relationship = new CourseStudent();
            //relationship.CourseId = course.Id;
            //relationship.StudentId = student.Id;

            //Student tempStudent = new Student();
            //tempStudent.Id = student.Id;
            //tempStudent.Name = course.Name;


            var errors = ModelState.Values.SelectMany(v => v.Errors);
            //course.Students.Add(student);
            foreach (Course item in _context.Course)
            {
                //Console.WriteLine(item);
                //Console.WriteLine(item.Students);
                foreach (Student stud in item.Students)
                {
                    Console.WriteLine("Student: " + stud.Name + stud.Id);
                }
            }

            //Console.WriteLine("Course ID: " + id + " Student Name: " + student.Id + " Student Name: " + student.Name);
            //course.Students.Add(new Student());

            //var thisCourse = new Course();

            //thisCourse.Id = id;
            //thisCourse.Students = ;

            //_context.Add(course.Students);
            //await _context.SaveChangesAsync();
            // return RedirectToAction(nameof(Index));

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(course);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!CourseExists(course.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            ViewData["Name"] = _context.Student.Select(x => new SelectListItem
            {

                Value = x.Id.ToString(),
                Text = x.Name,

            }).ToList();
            return View(course);
        }
    }
}
