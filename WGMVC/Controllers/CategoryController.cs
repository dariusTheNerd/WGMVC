using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WGMVC;

namespace WGMVC.Controllers
{ 
    public class CategoryController : Controller
    {
        private WGEntities db = new WGEntities();

        //
        // GET: /Category/

        public ViewResult Index()
        {
            return View(db.WGCategories.ToList());
        }

        //
        // GET: /Category/Details/5

        public ViewResult Details(int id)
        {
            WGCategory wgcategory = db.WGCategories.Single(w => w.Id == id);
            return View(wgcategory);
        }

        //
        // GET: /Category/Create
         [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Category/Create

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Create(WGCategory wgcategory)
        {
            if (ModelState.IsValid)
            {
                db.WGCategories.AddObject(wgcategory);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(wgcategory);
        }
        
        //
        // GET: /Category/Edit/5
  [Authorize(Roles = "admin")]
        public ActionResult Edit(int id)
        {
            WGCategory wgcategory = db.WGCategories.Single(w => w.Id == id);
            return View(wgcategory);
        }

        //
        // POST: /Category/Edit/5

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Edit(WGCategory wgcategory)
        {
            if (ModelState.IsValid)
            {
                db.WGCategories.Attach(wgcategory);
                db.ObjectStateManager.ChangeObjectState(wgcategory, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wgcategory);
        }

        //
        // GET: /Category/Delete/5
  [Authorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            WGCategory wgcategory = db.WGCategories.Single(w => w.Id == id);
            return View(wgcategory);
        }

        //
        // POST: /Category/Delete/5

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "admin")]
        public ActionResult DeleteConfirmed(int id)
        {            
            WGCategory wgcategory = db.WGCategories.Single(w => w.Id == id);
            db.WGCategories.DeleteObject(wgcategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}