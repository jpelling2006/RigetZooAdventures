using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RigetZooAdventures.Data;
using RigetZooAdventures.Models;

namespace RigetZooAdventures.Controllers
{
    [Authorize]
    public class HotelBookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelBookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HotelBookings
        public async Task<IActionResult> Index()
        {
              return _context.HotelBooking != null ? 
                          View(await _context.HotelBooking.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.HotelBooking'  is null.");
        }

        // GET: HotelBookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HotelBooking == null)
            {
                return NotFound();
            }

            var hotelBooking = await _context.HotelBooking
                .FirstOrDefaultAsync(m => m.HotelBookingID == id);
            if (hotelBooking == null)
            {
                return NotFound();
            }

            return View(hotelBooking);
        }

        // GET: HotelBookings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HotelBookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HotelBookingID,StartDate,EndDate,Username,Adults,Children,RoomType,RoomAmount,DateBooked")] HotelBooking hotelBooking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hotelBooking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotelBooking);
        }

        // GET: HotelBookings/Edit/5
        [Authorize(Policy = "EmployeeOnly")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HotelBooking == null)
            {
                return NotFound();
            }

            var hotelBooking = await _context.HotelBooking.FindAsync(id);
            if (hotelBooking == null)
            {
                return NotFound();
            }
            return View(hotelBooking);
        }

        // POST: HotelBookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "EmployeeOnly")]
        public async Task<IActionResult> Edit(int id, [Bind("HotelBookingID,StartDate,EndDate,Username,Adults,Children,RoomType,RoomAmount,DateBooked")] HotelBooking hotelBooking)
        {
            if (id != hotelBooking.HotelBookingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotelBooking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelBookingExists(hotelBooking.HotelBookingID))
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
            return View(hotelBooking);
        }

        // GET: HotelBookings/Delete/5
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HotelBooking == null)
            {
                return NotFound();
            }

            var hotelBooking = await _context.HotelBooking
                .FirstOrDefaultAsync(m => m.HotelBookingID == id);
            if (hotelBooking == null)
            {
                return NotFound();
            }

            return View(hotelBooking);
        }

        // POST: HotelBookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HotelBooking == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HotelBooking'  is null.");
            }
            var hotelBooking = await _context.HotelBooking.FindAsync(id);
            if (hotelBooking != null)
            {
                _context.HotelBooking.Remove(hotelBooking);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelBookingExists(int id)
        {
          return (_context.HotelBooking?.Any(e => e.HotelBookingID == id)).GetValueOrDefault();
        }
    }
}
