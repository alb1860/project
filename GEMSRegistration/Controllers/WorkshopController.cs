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
    public class WorkshopController : Controller
    {
        private readonly GEMSRegistrationContext _context;

        public WorkshopController(GEMSRegistrationContext context)
        {
            _context = context;
        }

        // GET: Workshop
        public async Task<IActionResult> Index()
        {
            var GEMSRegistrationContext = _context.Workshops
                .Include(w => w.Facilitator)
                .Include(w => w.Participant);
            return View(await GEMSRegistrationContext.ToListAsync());
        }

        // GET: Workshop/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @workshop = await _context.Workshops
                .Include(w => w.Facilitator)
                .Include(w => w.Participant)
                .FirstOrDefaultAsync(m => m.WorkshopID == id);
            if (@workshop == null)
            {
                return NotFound();
            }

            return View(@workshop);
        }

        // GET: Workshop/Create
        public IActionResult Create()
        {
            //ViewData["FacilitatorID"] = new SelectList(_context.Facilitators, "ID", "LName");
            //ViewData["ParticipantID"] = new SelectList(_context.Participants, "ID", "LName");
            SetDropdownLists();
            return View();
        }

        // POST: Workshop/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WorkshopID,WorkshopName,WorkshopDescription,FacilitatorID,ParticipantID")] Workshop @workshop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@workshop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FacilitatorID"] = new SelectList(_context.Facilitators, "ID", "LName", @workshop.FacilitatorID);
            ViewData["ParticipantID"] = new SelectList(_context.Participants, "ID", "LName", @workshop.ParticipantID);
            //SetDropdownLists(@workshop);
            return View(@workshop);
        }

        // GET: Workshop/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @workshop = await _context.Workshops.FindAsync(id);
            if (@workshop == null)
            {
                return NotFound();
            }
            ViewData["FacilitatorID"] = new SelectList(_context.Facilitators, "ID", "LName", @workshop.FacilitatorID);
            ViewData["ParticipantID"] = new SelectList(_context.Participants, "ID", "LName", @workshop.ParticipantID);
            return View(@workshop);
        }

        // POST: Workshop/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WorkshopID,WorkshopName,WorkshopDescription,FacilitatorID,ParticipantID")] Workshop @workshop)
        {
            if (id != @workshop.WorkshopID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@workshop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkshopExists(@workshop.WorkshopID))
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
            ViewData["FacilitatorID"] = new SelectList(_context.Facilitators, "ID", "ID", @workshop.FacilitatorID);
            ViewData["ParticipantID"] = new SelectList(_context.Participants, "ID", "ID", @workshop.ParticipantID);
            return View(workshop);
        }

        // GET: Workshop/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @workshop = await _context.Workshops
                .Include(w => w.Facilitator)
                .Include(w => w.Participant)
                .FirstOrDefaultAsync(m => m.WorkshopID == id);
            if (@workshop == null)
            {
                return NotFound();
            }

            return View(@workshop);
        }

        // POST: Workshop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @workshop = await _context.Workshops.FindAsync(id);
            _context.Workshops.Remove(@workshop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkshopExists(int id)
        {
            return _context.Workshops.Any(e => e.WorkshopID == id);
        }

        private void SetDropdownLists()
        {
            ViewData["FacilitatorID"] = new SelectList(_context.Facilitators, "ID", "LName");
            ViewData["ParticipantID"] = new SelectList(_context.Participants, "ID", "LName");
        }

        private void SetDropdownLists(Workshop @workshop)
        {
            ViewData["FacilitatorID"] = new SelectList(_context.Facilitators, "FacilitatorID", "LName", @workshop.FacilitatorID);
            ViewData["ParticipantID"] = new SelectList(_context.Participants, "ParticipatorID", "LName", @workshop.ParticipantID);
        }
    }
}
