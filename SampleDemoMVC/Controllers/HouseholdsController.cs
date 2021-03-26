using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SampleDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDemoMVC.Controllers
{
    public class HouseholdsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HouseholdsController(ApplicationDbContext context)
        {
            _context = context;
        }
         public async Task<IActionResult> Index(Ward vm)
        {
                var data = _context.Wards
                    .Include(i => i.Id)
                    .Include(i => i.Name)
                    .Include(i => i.ConstituencyId)
                    .Include(i => i.Code)
                    .OrderByDescending(i => i.Id)
                    .AsQueryable();

                    ViewBag.CountyId = new SelectList(await _context.Wards
                   .Include(i => i.Id)
                   .Include(i => i.Name).ToListAsync(), "Id", "Name", vm.Id);

                   return View(vm);
            
        }
        public async Task<IActionResult> ListedHouseholds(Ward vm)
        {
            var data = _context.Wards
                .Include(i => i.Id)
                .Include(i => i.Name)
                .Include(i => i.ConstituencyId)
                .Include(i => i.Code)
                .OrderByDescending(i => i.Id)
                .AsQueryable();

            ViewBag.CountyId = new SelectList(await _context.Wards
                .Include(i => i.Id)
                .Include(i => i.Name).ToListAsync(), "Id", "Name", vm.Id);

            return View(vm);

        }
        

        // GET: HouseholdsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HouseholdsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HouseholdsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HouseholdsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HouseholdsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HouseholdsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HouseholdsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
