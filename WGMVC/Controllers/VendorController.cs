using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WGMVC;
using PagedList;
using PagedList.Mvc;


namespace WGMVC.Controllers
{
     [Authorize(Roles = "admin")]
    public class VendorController : Controller
    {
        private WGEntities db = new WGEntities();

        //
        // GET: /Vendor/
         //for the pager, we need a parameter for the pageNumber
        public ViewResult Index(int page=1)
        {
            int pageSize = 2;

            return View(db.WGVendors.OrderBy(x =>x.Name).ToList().ToPagedList(page, pageSize));
        }

        //
        // GET: /Vendor/Details/5

        public ViewResult Details(int id)
        {
            WGVendor wgvendor = db.WGVendors.Single(w => w.ID == id);
            return View(wgvendor);
        }

        //
        // GET: /Vendor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Vendor/Create

        [HttpPost]
        public ActionResult Create(WGVendor wgvendor)
        {
            if (ModelState.IsValid)
            {
                db.WGVendors.AddObject(wgvendor);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(wgvendor);
        }
        
        //
        // GET: /Vendor/Edit/5
 
        public ActionResult Edit(int id)
        {
            WGVendor wgvendor = db.WGVendors.Single(w => w.ID == id);
            return View(wgvendor);
        }

        //
        // POST: /Vendor/Edit/5

        [HttpPost]
        public ActionResult Edit(WGVendor wgvendor)
        {
            if (ModelState.IsValid)
            {
                db.WGVendors.Attach(wgvendor);
                db.ObjectStateManager.ChangeObjectState(wgvendor, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wgvendor);
        }

        //
        // GET: /Vendor/Delete/5
 
        public ActionResult Delete(int id)
        {
            WGVendor wgvendor = db.WGVendors.Single(w => w.ID == id);
            return View(wgvendor);
        }

        //
        // POST: /Vendor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            WGVendor wgvendor = db.WGVendors.Single(w => w.ID == id);
            db.WGVendors.DeleteObject(wgvendor);
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