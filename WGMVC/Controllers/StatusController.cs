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
    [Authorize(Roles = "admin")]
    public class StatusController : Controller
    {
        private WGEntities db = new WGEntities();

        //
        // GET: /Status/

        public ViewResult Index()
        {
            return View(db.WGStatus.ToList());
        }

        //
        // GET: /Status/Details/5

        public ViewResult Details(int id)
        {
            WGStatu wgstatu = db.WGStatus.Single(w => w.ID == id);
            return View(wgstatu);
        }

        //
        // GET: /Status/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Status/Create

        [HttpPost]
        public ActionResult Create(WGStatu wgstatu)
        {
            if (ModelState.IsValid)
            {
                db.WGStatus.AddObject(wgstatu);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(wgstatu);
        }
        
        //
        // GET: /Status/Edit/5
 
        public ActionResult Edit(int id)
        {
            WGStatu wgstatu = db.WGStatus.Single(w => w.ID == id);
            return View(wgstatu);
        }

        //
        // POST: /Status/Edit/5

        [HttpPost]
        public ActionResult Edit(WGStatu wgstatu)
        {
            if (ModelState.IsValid)
            {
                db.WGStatus.Attach(wgstatu);
                db.ObjectStateManager.ChangeObjectState(wgstatu, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wgstatu);
        }

        //
        // GET: /Status/Delete/5
 
        public ActionResult Delete(int id)
        {
            WGStatu wgstatu = db.WGStatus.Single(w => w.ID == id);
            return View(wgstatu);
        }

        //
        // POST: /Status/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            WGStatu wgstatu = db.WGStatus.Single(w => w.ID == id);
            db.WGStatus.DeleteObject(wgstatu);
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