//Angelia Bendolph
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GEMSRegistration.DAL;
using GEMSRegistration.Models;

namespace GEMSRegistration.Controllers
{
    public class AttendeeController : Controller
    {
        private readonly GEMSRegistrationContext _context;

        public AttendeeController(GEMSRegistrationContext context)
        {
            _context = context;
        }

        // GET: Attendee
        public async Task<IActionResult> Index()
        {
            var gEMSRegistrationContext = _context.Attendees.Include(a => a.Location).Include(a => a.Workshop);
            return View(await gEMSRegistrationContext.ToListAsync());
        }

        // GET: Attendee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendee = await _context.Attendees
                .Include(a => a.Location)
                .Include(a => a.Workshop)
                .FirstOrDefaultAsync(m => m.AttendeeID == id);
            if (attendee == null)
            {
                return NotFound();
            }

            return View(attendee);
        }

        // GET: Attendee/Create
        public IActionResult Create()
        {
            ViewData["LocationID"] = new SelectList(_context.Locations, "LocationID", "LocationName");
            ViewData["WorkshopID"] = new SelectList(_context.Workshops, "WorkshopID", "WorkshopName");
            return View();
        }

        // POST: Attendee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AttendeeID,Quantity,WorkshopID,LocationID")] Attendee attendee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(attendee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationID"] = new SelectList(_context.Locations, "LocationID", "LocationName", attendee.LocationID);
            ViewData["WorkshopID"] = new SelectList(_context.Workshops, "WorkshopID", "WorkshopName", attendee.WorkshopID);
            return View(attendee);
        }

        // GET: Attendee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendee = await _context.Attendees.FindAsync(id);
            if (attendee == null)
            {
                return NotFound();
            }
            ViewData["LocationID"] = new SelectList(_context.Locations, "LocationID", "LocationName", attendee.LocationID);
            ViewData["WorkshopID"] = new SelectList(_context.Workshops, "WorkshopID", "WorkshopName", attendee.WorkshopID);
            return View(attendee);
        }

        // POST: Attendee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AttendeeID,Quantity,WorkshopID,LocationID")] Attendee attendee)
        {
            if (id != attendee.AttendeeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(attendee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AttendeeExists(attendee.AttendeeID))
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
            ViewData["LocationID"] = new SelectList(_context.Locations, "LocationID", "LocationID", attendee.LocationID);
            ViewData["WorkshopID"] = new SelectList(_context.Workshops, "WorkshopID", "WorkshopDescription", attendee.WorkshopID);
            return View(attendee);
        }

        // GET: Attendee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendee = await _context.Attendees
                .Include(a => a.Location)
                .Include(a => a.Workshop)
                .FirstOrDefaultAsync(m => m.AttendeeID == id);
            if (attendee == null)
            {
                return NotFound();
            }

            return View(attendee);
        }

        // POST: Attendee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var attendee = await _context.Attendees.FindAsync(id);
            _context.Attendees.Remove(attendee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AttendeeExists(int id)
        {
            return _context.Attendees.Any(e => e.AttendeeID == id);
        }
    }
}
