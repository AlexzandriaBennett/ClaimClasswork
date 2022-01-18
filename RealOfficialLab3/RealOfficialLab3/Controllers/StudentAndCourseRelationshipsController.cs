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

namespace RealOfficialLab3.Controllers
{
    public class StudentAndCourseRelationshipsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentAndCourseRelationshipsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentAndCourseRelationships
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentAndCourseRelationship.ToListAsync());
        }

        // GET: StudentAndCourseRelationships/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentAndCourseRelationship = await _context.StudentAndCourseRelationship
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentAndCourseRelationship == null)
            {
                return NotFound();
            }

            return View(studentAndCourseRelationship);
        }

        // GET: StudentAndCourseRelationships/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentAndCourseRelationships/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentNumber,CourseNumber")] StudentAndCourseRelationship studentAndCourseRelationship)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentAndCourseRelationship);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentAndCourseRelationship);
        }

        // GET: StudentAndCourseRelationships/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentAndCourseRelationship = await _context.StudentAndCourseRelationship.FindAsync(id);
            if (studentAndCourseRelationship == null)
            {
                return NotFound();
            }
            return View(studentAndCourseRelationship);
        }

        // POST: StudentAndCourseRelationships/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentNumber,CourseNumber")] StudentAndCourseRelationship studentAndCourseRelationship)
        {
            if (id != studentAndCourseRelationship.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentAndCourseRelationship);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentAndCourseRelationshipExists(studentAndCourseRelationship.Id))
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
            return View(studentAndCourseRelationship);
        }

        // GET: StudentAndCourseRelationships/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentAndCourseRelationship = await _context.StudentAndCourseRelationship
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentAndCourseRelationship == null)
            {
                return NotFound();
            }

            return View(studentAndCourseRelationship);
        }

        // POST: StudentAndCourseRelationships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentAndCourseRelationship = await _context.StudentAndCourseRelationship.FindAsync(id);
            _context.StudentAndCourseRelationship.Remove(studentAndCourseRelationship);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentAndCourseRelationshipExists(int id)
        {
            return _context.StudentAndCourseRelationship.Any(e => e.Id == id);
        }
    }
}
