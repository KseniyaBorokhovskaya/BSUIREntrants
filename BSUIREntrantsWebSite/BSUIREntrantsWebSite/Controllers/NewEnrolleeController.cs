using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BSUIREntrantsWebSite.Concrete;
using BSUIREntrantsWebSite.Models;

namespace BSUIREntrantsWebSite.Controllers
{
    public class NewEnrolleeController : Controller
    {
        private UniversityContext db = new UniversityContext();
        private UniversitiesTreeContext treeDb = new UniversitiesTreeContext();

        // GET: NewEnrollee
        public ActionResult Index()
        {
            return View(db.Entranst.ToList());
        }

        // GET: NewEnrollee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollee enrollee = db.Entranst.Find(id);
            if (enrollee == null)
            {
                return HttpNotFound();
            }
            return View(enrollee);
        }

        // GET: NewEnrollee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewEnrollee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LastName,FirstName,HomeTown,TotalScore,BirthDate,University,Faculty,Speciality")] Enrollee enrollee)
        {
            if (ModelState.IsValid)
            {
                db.Entranst.Add(enrollee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enrollee);
        }

        // GET: NewEnrollee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollee enrollee = db.Entranst.Find(id);
            if (enrollee == null)
            {
                return HttpNotFound();
            }
            return View(enrollee);
        }

        // POST: NewEnrollee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LastName,FirstName,HomeTown,TotalScore,BirthDate,University,Faculty,Speciality")] Enrollee enrollee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enrollee);
        }

        // GET: NewEnrollee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollee enrollee = db.Entranst.Find(id);
            if (enrollee == null)
            {
                return HttpNotFound();
            }
            return View(enrollee);
        }

        // POST: NewEnrollee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enrollee enrollee = db.Entranst.Find(id);
            db.Entranst.Remove(enrollee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public JsonResult GetUniversities()
        {      
            List<UniversityNode> items = treeDb.UniversityNodes.Where(uni => uni.parentId == "#").ToList();
            //var node = new UniversityNode { id = "1", parentId = "#", text = "BSUIR", children = true };
            //items.Add(node);
            return new JsonResult { Data = items, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        [HttpPost]
        public JsonResult GetFaculties(string id)
        {
            List<UniversityNode> items = treeDb.UniversityNodes.Where(uni => uni.parentId == id).ToList();
            //var node = new UniversityNode { id = "2", parentId = "1", text = "KSIS", children = true };
            //items.Add(node);
            return new JsonResult { Data = items, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        [HttpPost]
        public JsonResult GetSpecialities(string id)
        {
            List<UniversityNode> items = treeDb.UniversityNodes.Where(uni => uni.parentId == id).ToList();
            return new JsonResult { Data = items, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
