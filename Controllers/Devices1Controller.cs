using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcDevices.Models;
using MvcDevices.Data;
using IPGeolocation;
using Project_APATE.Models;

namespace Project_APATE.Controllers
{
    public class Devices1Controller : Controller
    {
        private readonly MvcDevicesContext _context;

        public Devices1Controller(MvcDevicesContext context)
        {
            _context = context;
        }

        // GET: Devices1
        public async Task<IActionResult> Index()
        {
            

            return View(await _context.Devices.ToListAsync());
        }

        // GET: Devices1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devices = await _context.Devices
                .FirstOrDefaultAsync(m => m.AssetID == id);
            if (devices == null)
            {
                return NotFound();
            }

            return View(devices);
        }

        // GET: Devices1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Devices1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssetID,AssetName,PublicIP,PrivateIP,ConnectionStatus,PrivilegeID,Hostname,ProjectID")] Devices devices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(devices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(devices);
        }

        // GET: Devices1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devices = await _context.Devices.FindAsync(id);
            if (devices == null)
            {
                return NotFound();
            }
            return View(devices);
        }

        // POST: Devices1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssetID,AssetName,PublicIP,PrivateIP,ConnectionStatus,PrivilegeID,Hostname,ProjectID")] Devices devices)
        {
            if (id != devices.AssetID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(devices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DevicesExists(devices.AssetID))
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
            return View(devices);
        }

        // GET: Devices1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devices = await _context.Devices
                .FirstOrDefaultAsync(m => m.AssetID == id);
            if (devices == null)
            {
                return NotFound();
            }

            return View(devices);
        }

        // POST: Devices1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var devices = await _context.Devices.FindAsync(id);
            _context.Devices.Remove(devices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DevicesExists(int id)
        {
            return _context.Devices.Any(e => e.AssetID == id);
        }
    }
}
