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
    public class ProductController : Controller
    {
        private WGEntities db = new WGEntities();

        //
        // GET: /Product/

        //for filtering, the parameter will match the name of the drop down,which came form the name of the slelcted 
        //list in the viewbag
        //3 parameters  for the SelectedList- data,valuefield, text field

        public ViewResult Index(int? CategoryId, string search,string newSearch, int page =1 )
        {
            int pageSize = 6;

            if (!string.IsNullOrEmpty(newSearch))
            {
                page = 1;
            }


            //add a selectList to the View bag for the category ddl filter
            ViewBag.CategoryId = new SelectList(db.WGCategories.OrderBy(x => x.Name),
                "Id", "Name");
            //convert th object set to a list to make it easier to filter
            var wgproducts = db.WgProducts.Include("WGCategory").Include("WGStatu").Include("WGVendor").OrderBy(x=> x.name).ToList();
            if (!User.IsInRole("admin"))
            {
                wgproducts = (from prod in wgproducts
                              where prod.StatusID < 4
                              select prod).ToList();
            }


            //if categoryID is not null, we will filter by category Id
            if (CategoryId !=null)
            {
                wgproducts = (from prod in wgproducts
                              where prod.CategoryID == CategoryId
                              select prod).ToList();
            }
           
            //if search is not null or empthp apply the search
            if (!String.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                wgproducts = (from prod in wgproducts
                              where prod.name.ToLower().Contains(search) ||
                              (prod.Description != null &&
                              prod.Description.ToLower().Contains(search))
                              select prod).ToList();

            }

            //save the filter value to the viewbag for the pager

            ViewBag.CurrentSearch = search;
            ViewBag.CurrentCategory = CategoryId;

            return View(wgproducts.ToPagedList(page, pageSize));
        }

        //
        // GET: /Product/Details/5

        public ViewResult Details(int id)
        {


            WgProduct wgproduct = db.WgProducts.Single(w => w.ID == id);
            return View(wgproduct);
        }

        //
        // GET: /Product/Create
        //admin only action
        [Authorize(Roles="admin")]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.WGCategories, "Id", "Name");
            ViewBag.StatusID = new SelectList(db.WGStatus, "ID", "Name");
            ViewBag.VendorID = new SelectList(db.WGVendors, "ID", "Name");
            return View();
        } 

        //
        // POST: /Product/Create

        [HttpPost]
        [Authorize(Roles = "admin")]
        //for the file upload 

        public ActionResult Create(WgProduct wgproduct, HttpPostedFileBase productImage )
        {
            if (ModelState.IsValid)
            {
                //make sure user uploaded file
                if (productImage != null)
                {
                    
              
                //get the file name 
                string filename = productImage.FileName;
                //get the ext
                    string ext = filename.Substring(filename.LastIndexOf("."));
                //rename file using a GUID  and add the ext back
                    string newFile = Guid.NewGuid().ToString() + ext;
                //save that file to the content/img directory
                    productImage.SaveAs(
                        Server.MapPath("~/Content/Img/"+ newFile));
                //save the new file  name in the product object
                    wgproduct.ImageUrl = newFile;
  }


                else
                {
                    //no file  uploaded, us the noimage.jpg
                    wgproduct.ImageUrl = "No_image_available.jpg";
                }
                db.WgProducts.AddObject(wgproduct);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.CategoryID = new SelectList(db.WGCategories, "Id", "Name", wgproduct.CategoryID);
            ViewBag.StatusID = new SelectList(db.WGStatus, "ID", "Name", wgproduct.StatusID);
            ViewBag.VendorID = new SelectList(db.WGVendors, "ID", "Name", wgproduct.VendorID);
            return View(wgproduct);
        }
        
        //
        // GET: /Product/Edit/5
  [Authorize(Roles = "admin")]
        public ActionResult Edit(int id)
        {
            WgProduct wgproduct = db.WgProducts.Single(w => w.ID == id);
            ViewBag.CategoryID = new SelectList(db.WGCategories, "Id", "Name", wgproduct.CategoryID);
            ViewBag.StatusID = new SelectList(db.WGStatus, "ID", "Name", wgproduct.StatusID);
            ViewBag.VendorID = new SelectList(db.WGVendors, "ID", "Name", wgproduct.VendorID);
            return View(wgproduct);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        [Authorize(Roles = "admin")]
        public ActionResult Edit(WgProduct wgproduct, HttpPostedFileBase productImage)
        {
            if (ModelState.IsValid)
            {
                if (productImage != null)
                {


                    //get the file name 
                    string filename = productImage.FileName;
                    //get the ext
                    string ext = filename.Substring(filename.LastIndexOf("."));
                    //rename file using a GUID  and add the ext back
                    string newFile = Guid.NewGuid().ToString() + ext;
                    //save that file to the content/img directory
                    productImage.SaveAs(
                        Server.MapPath("~/Content/Img/" + newFile));
                    //save the new file  name in the product object
                    wgproduct.ImageUrl = newFile;
                }
                
                
                
                db.WgProducts.Attach(wgproduct);
                db.ObjectStateManager.ChangeObjectState(wgproduct, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.WGCategories, "Id", "Name", wgproduct.CategoryID);
            ViewBag.StatusID = new SelectList(db.WGStatus, "ID", "Name", wgproduct.StatusID);
            ViewBag.VendorID = new SelectList(db.WGVendors, "ID", "Name", wgproduct.VendorID);
            return View(wgproduct);
        }

        //
        // GET: /Product/Delete/5
  [Authorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            WgProduct wgproduct = db.WgProducts.Single(w => w.ID == id);
            return View(wgproduct);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "admin")]
        public ActionResult DeleteConfirmed(int id)
        {            
            WgProduct wgproduct = db.WgProducts.Single(w => w.ID == id);
            //db.WgProducts.DeleteObject(wgproduct);
            wgproduct.StatusID = 4;
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