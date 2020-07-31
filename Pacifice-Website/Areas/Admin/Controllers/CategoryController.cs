using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pacifice_Website.Data;
using Pacifice_Website.Models;

namespace Pacifice_Website.Areas.Admin.Controllers
{
    [Area("Admin")] //here i alwas make mistake
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;
      
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
           
        }
        [HttpGet]
        public IActionResult Index()
        {
            var category = _context.Category.ToList();
            return View(category);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //HttpPost for Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                //For  Redandent category Name do not Create
                var sameCatCheck = _context.Category.FirstOrDefault(c => c.Name == category.Name);
                if (sameCatCheck != null)
                {
                    TempData["create"] = "This Category All Ready Exist";
                    return View(category);
                }
                _context.Category.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        //HttpGet for Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _context.Category.FirstOrDefault(c => c.Id == id);
            return View(category);
        }
        //HttpPost for Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category categoryVm)
        {
            if (id != categoryVm.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var categorySameName = _context.Category.FirstOrDefault(c => c.Name == categoryVm.Name && c.Id != categoryVm.Id);
                //For  Redandent category Name do not update
                if (categorySameName != null)
                {                
                    TempData["create"] = "This Category All Ready Exist";
                    return View(categoryVm);
                }
                // Image not want to edit
                    
                
               var category1 = _context.Category.FirstOrDefault(c => c.Id == categoryVm.Id);
               category1.Name = categoryVm.Name;
               _context.Category.Update(category1);
                await _context.SaveChangesAsync();
                TempData["update"] = "This Product successfuly update";
                return RedirectToAction(nameof(Index));
             }
            return View(categoryVm);
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _context.Category.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        //HttpGet for Delete
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _context.Category.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            var category = _context.Category.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Category.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}