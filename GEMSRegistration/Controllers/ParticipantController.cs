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
    public class ParticipantController : Controller
    {
        private readonly GEMSRegistrationContext _context;

        public ParticipantController(GEMSRegistrationContext context)
        {
            _context = context;
        }

        // GET: Participant
        public async Task<IActionResult> Index()
        {
            return View(await _context.Participants.ToListAsync());
        }

        // GET: Participant/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        public async Task<IActionResult> DetailsAjax(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var participant = await _context.Participants.FirstOrDefaultAsync(m => m.ID == id);

            if (participant == null)
            {
                return NotFound();
            }
            //AddClickedActToSession(participant);
            return View(participant);
        }

        //Partial POST: GetParticipantWorkshops
        [HttpPost]
        public async Task<IActionResult> GetParticipantWorkshops(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var participant = await _context.Participants
                .Include(m => m.Workshops).ThenInclude(e => e.Facilitator)
               // .Include(m => m.Workshops).ThenInclude(e => e.Attendees)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (participant == null)
            {
                return NotFound();
            }

            return PartialView("_ParticipantWorkshops", participant.Workshops.ToList());
        }

        // GET: Participant/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Participant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContactFName,ContactLName,Age,RegistrationDate,ID,FName,LName,Phone,Email")] Participant participant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(participant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(participant);
        }

        // GET: Participant/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participants.FindAsync(id);
            if (participant == null)
            {
                return NotFound();
            }
            return View(participant);
        }

        // POST: Participant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContactFName,ContactLName,Age,RegistrationDate,ID,FName,LName,Phone,Email")] Participant participant)
        {
            if (id != participant.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(participant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParticipantExists(participant.ID))
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
            return View(participant);
        }

        // GET: Participant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participant = await _context.Participants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        // POST: Participant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var participant = await _context.Participants.FindAsync(id);
            _context.Participants.Remove(participant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParticipantExists(int id)
        {
            return _context.Participants.Any(e => e.ID == id);
        }
    }
}
