﻿using Microsoft.AspNetCore.Mvc;

namespace BookStoreAppMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category>objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj); /*_db.Categories.Add(obj);*/
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id==0)
            {
                return NotFound();
            }
            Category? categoryFromDatabase = _db.Categories.Find(id);
            //Category? categoryFromDatabase2 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //Category? categoryFromDatabase3 = _db.Categories.Where(u => u.Id == id).FirstOrDefault();
            if (categoryFromDatabase == null)
            {
                return NotFound();
            }
            return View(categoryFromDatabase);
        }
       
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            //if (obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("name", "The DisplayOrder doesn't match the Name! ");
            //}
            //if (obj.Name !=null && obj.Name.ToLower()=="test")
            //{
            //    ModelState.AddModelError("", "Test is an invalid value");
            //}
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj); /*_db.Categories.Add(obj);*/
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
           return View();
            
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Category? categoryFromDatabase = _db.Categories.Find(id);

            if (categoryFromDatabase == null)
            {
                return NotFound();
            }
            return View(categoryFromDatabase);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
    
}
