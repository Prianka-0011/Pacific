
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pacifice_Website.Data;
using Pacifice_Website.Models;
using Pacifice_Website.ViewModel;

namespace Pacifice_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;
 
        private IHostingEnvironment _hosting;
        public ProductController(ApplicationDbContext context, IHostingEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
          
        }
        public IActionResult Index(string srcText)
        {
            IQueryable<Product> products = _context.Product.Include(c => c.Category);
            ViewBag.srcText = srcText;
            if (srcText != null)
            {
                srcText = srcText.ToLower();
                products = _context.Product.Include(c => c.Category).Where(c => c.Name.ToLower().Contains(srcText));
            }

            //ViewData["Category"] = new SelectList(_context.Categories.ToList(), "Id", "Name");
            return View(products);
        }
        //HttpGet for Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Category"] = new SelectList(_context.Category.ToList(), "Id", "Name");
            return View();
        }
        //httpPost for Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdctVm productVm)
        {
            if (ModelState.IsValid)
            {
                var sameProductCheck = _context.Product.FirstOrDefault(c => c.Name == productVm.Name);
                if (sameProductCheck != null)
                {
                    TempData["create"] = "This Product All Ready Exist";
                    return View(productVm);
                }
                Product product = new Product();
                product.Name = productVm.Name;
                product.Model = productVm.Model;
                product.Price = productVm.Price;
                product.Grade = productVm.Grade;
                product.CarCc = productVm.CarCc;
                product.Seating = productVm.Seating;
                product.Fuel = productVm.Fuel;
                product.Condition = productVm.Condition;
                product.Color = productVm.Color;
                product.CategoryId = productVm.CategoryId;
                product.Transmission = productVm.Transmission;
                product.Year = productVm.Year;
                product.Status = productVm.Status;
                product.Option = productVm.Option;
                product.Description = productVm.Description;
                _context.Product.Add(product);
                await _context.SaveChangesAsync();
                string uniqueFileNAme = null;
                if (productVm.Images !=null && productVm.Images.Count>0)
                {
                    foreach (IFormFile image in productVm.Images)
                    {
                        
                        string uploadsFolder = Path.Combine(_hosting.WebRootPath, "images");
                        uniqueFileNAme = Guid.NewGuid().ToString() + "_" + image.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileNAme);
                        await image.CopyToAsync(new FileStream(filePath, FileMode.Create));
                        var imagPath = new Image();
                        imagPath.Name = image.FileName;
                        imagPath.ProductId = product.Id;
                        _context.Image.Add(imagPath);
                        //product.Image= "Images/" + uniqueFileNAme;
                    }
                }
                if (productVm.Image!=null)
                {

                    string uploadsFolder = Path.Combine(_hosting.WebRootPath, "images");
                    uniqueFileNAme = Guid.NewGuid().ToString() + "_" + productVm.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileNAme);
                    await productVm.Image.CopyToAsync(new FileStream(filePath, FileMode.Create));
                    product.Image = "Images/" + uniqueFileNAme;
                }
              
                
                _context.Product.Update(product);
              //  product = (Product)_mapper.Map(productVm, product, typeof(ProdctVm), typeof(Product));
               // _mapper.Map<ProdctVm ,Product>(productVm,product);
                //_context.Product.Add();
                await _context.SaveChangesAsync();
                TempData["create"] = "This Product successfuly Create";
                return RedirectToAction(nameof(Index));
            }
            ViewData["Category"] = new SelectList(_context.Category.ToList(), "Id", "Name");
            return View(productVm);
        }
        //HttpGet For Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["Category"] = new SelectList(_context.Category.ToList(), "Id", "Name");
            var product = _context.Product.Include(c => c.Category).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            var productVm = new ProdctVm();
            productVm.Id = product.Id;
            productVm.Name = product.Name;
            productVm.Model = product.Model;
            productVm.Price = product.Price;
            productVm.Grade = product.Grade;
            productVm.CarCc = product.CarCc;
            productVm.Seating = product.Seating;
            productVm.Fuel = product.Fuel;
            productVm.Condition = product.Condition;
            productVm.Color = product.Color;
            productVm.CategoryId = product.CategoryId;
            productVm.Transmission = product.Transmission;
            productVm.Year = product.Year;
            productVm.DisplayImage = product.Image;
            productVm.Status = product.Status;
            productVm.Option = product.Option;
            productVm.Description = product.Description;
            return View(productVm);
        }
        //HttpPost for Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProdctVm productVm)
        {
            if (id != productVm.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var product = _context.Product.FirstOrDefault(c => c.Id == productVm.Id);
                var sameProductCheck = _context.Product.FirstOrDefault(c => c.Name == productVm.Name && c.Id != productVm.Id);

                if (sameProductCheck != null)
                {
                    if (productVm.Image == null)
                    {
                        var productImageFind = _context.Product.FirstOrDefault(c => c.Id == id);
                        productVm.DisplayImage = productImageFind.Image;
                    }

                    if (productVm.Image != null)
                    {
                        var productImageFind = _context.Product.FirstOrDefault(c => c.Id == id);
                        productVm.DisplayImage = productImageFind.Image;
                    }
                    TempData["update"] = "This Product Name Already Exist";
                    return View(productVm);
                }
                string uniqueFileNAme = null;
                product.Name = productVm.Name;
                product.Model = productVm.Model;
                product.Price = productVm.Price;
                product.Grade = productVm.Grade;
                product.CarCc = productVm.CarCc;
                product.Seating = productVm.Seating;
                product.Fuel = productVm.Fuel;
                product.Condition = productVm.Condition;
                product.Color = productVm.Color;
                product.CategoryId = productVm.CategoryId;
                product.Transmission = productVm.Transmission;
                product.Year = productVm.Year;
                product.Status = productVm.Status;
                product.Option = productVm.Option;
                product.Description = productVm.Description;
                if (productVm.Images != null && productVm.Images.Count > 0)
                {
                    var deleteOldImg = _context.Image.Where(c => c.ProductId == productVm.Id);
                    foreach (var item in deleteOldImg)
                    {
                        _context.Image.Remove(item);
                    }
                    await _context.SaveChangesAsync();
                    foreach (IFormFile image in productVm.Images)
                    {   
                        string uploadsFolder = Path.Combine(_hosting.WebRootPath, "images");
                        uniqueFileNAme = Guid.NewGuid().ToString() + "_" + image.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileNAme);
                        await image.CopyToAsync(new FileStream(filePath, FileMode.Create));
                        var imagPath = new Image();
                        imagPath.Name = image.FileName;
                        imagPath.ProductId = productVm.Id;      
                       
                        _context.Image.Add(imagPath);
                        product.Image = "Images/" + uniqueFileNAme;
                    }
                }
                if (productVm.Image != null)
                {

                    string uploadsFolder = Path.Combine(_hosting.WebRootPath, "images");
                    uniqueFileNAme = Guid.NewGuid().ToString() + "_" + productVm.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileNAme);
                    await productVm.Image.CopyToAsync(new FileStream(filePath, FileMode.Create));
                    product.Image = "Images/" + uniqueFileNAme;
                }

                _context.Product.Update(product);
                await _context.SaveChangesAsync();
                TempData["update"] = "This Product successfuly Update";
                return RedirectToAction(nameof(Index));

            }
            var productImageFind1 = _context.Product.FirstOrDefault(c => c.Id == id);
            productVm.DisplayImage = productImageFind1.Image;
            return View(productVm);
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            // ViewData["Category"] = new SelectList(_context.Category.ToList(), "Id", "Name");
            var product = _context.Product.Include(c => c.Category).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            var productVm = new DeleteProducrtVm();

            productVm.Id = product.Id;
            productVm.Name = product.Name;
            productVm.Model = product.Model;
            productVm.Price = product.Price;
            productVm.Grade = product.Grade;
            productVm.CarCc = product.CarCc;
            productVm.Seating = product.Seating;
            productVm.Fuel = product.Fuel;
            productVm.Condition = product.Condition;
            productVm.Color = product.Color;
            productVm.CategoryName = product.Category.Name;
            productVm.Transmission = product.Transmission;
            productVm.Year = product.Year;
            productVm.Image = product.Image;
            productVm.Status = product.Status;
            productVm.Option = product.Option;
            productVm.Description = product.Description;
            return View(productVm);
        }
        //HttpGet For Delete
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           // ViewData["Category"] = new SelectList(_context.Category.ToList(), "Id", "Name");
            var product = _context.Product.Include(c => c.Category).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
           
            var productVm = new DeleteProducrtVm();
            
            productVm.Id = product.Id;
            productVm.Name = product.Name;
            productVm.Model = product.Model;
            productVm.Price = product.Price;
            productVm.Grade = product.Grade;
            productVm.CarCc = product.CarCc;
            productVm.Seating = product.Seating;
            productVm.Fuel = product.Fuel;
            productVm.Condition = product.Condition;
            productVm.Color = product.Color;
            productVm.CategoryName = product.Category.Name;
            productVm.Transmission = product.Transmission;
            productVm.Year = product.Year;
            productVm.Image = product.Image;
            productVm.Status = product.Status;
            productVm.Option = product.Option;
            productVm.Description = product.Description;
            return View(productVm);
        }
        //httpPost for Delete
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            var product = _context.Product.FirstOrDefault(c => c.Id == id);
            _context.Product.Remove(product);
           await _context.SaveChangesAsync();            
           return RedirectToAction(nameof(Index));
        }

    }

}
    