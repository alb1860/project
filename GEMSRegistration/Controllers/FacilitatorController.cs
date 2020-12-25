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
    public class FacilitatorController : Controller
    {
        private readonly GEMSRegistrationContext _context;

        public FacilitatorController(GEMSRegistrationContext context)
        {
            _context = context;
        }

        // GET: Facilitator
        public async Task<IActionResult> Index()
        {
            return View(await _context.Facilitators.ToListAsync());
        }

        // GET: Facilitator/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facilitator = await _context.Facilitators
                .FirstOrDefaultAsync(m => m.ID == id);
            if (facilitator == null)
            {
                return NotFound();
            }

            return View(facilitator);
        }

        public async Task<IActionResult> DetailsAjax(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facilitator = await _context.Facilitators.FirstOrDefaultAsync(m => m.ID == id);

            if (facilitator == null)
            {
                return NotFound();
            }
            //AddClickedActToSession(participant);
            return View(facilitator);
        }

        //Partial POST: GetFacilitatorWorkshops
        [HttpPost]
        public async Task<IActionResult> GetFacilitatorWorkshops(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var facilitator = await _context.Facilitators
                .Include(m => m.Workshops).ThenInclude(e => e.Participant)
                // .Include(m => m.Workshops).ThenInclude(e => e.Attendees)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (facilitator == null)
            {
                return NotFound();
            }

            return PartialView("_FacilitatorWorkshops", facilitator.Workshops.ToList());
        }

        // GET: Facilitator/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Facilitator/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Affiliation,ID,FName,LName,Phone,Email")] Facilitator facilitator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facilitator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(facilitator);
        }

        // GET: Facilitator/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facilitator = await _context.Facilitators.FindAsync(id);
            if (facilitator == null)
            {
                return NotFound();
            }
            return View(facilitator);
        }

        // POST: Facilitator/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Affiliation,ID,FName,LName,Phone,Email")] Facilitator facilitator)
        {
            if (id != facilitator.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facilitator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacilitatorExists(facilitator.ID))
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
            return View(facilitator);
        }

        // GET: Facilitator/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facilitator = await _context.Facilitators
                .FirstOrDefaultAsync(m => m.ID == id);
            if (facilitator == null)
            {
                return NotFound();
            }

            return View(facilitator);
        }

        // POST: Facilitator/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facilitator = await _context.Facilitators.FindAsync(id);
            _context.Facilitators.Remove(facilitator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacilitatorExists(int id)
        {
            return _context.Facilitators.Any(e => e.ID == id);
        }
    }
}
