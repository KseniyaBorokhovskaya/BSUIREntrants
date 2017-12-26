using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using BSUIREntrantsWebSite.Concrete;
using BSUIREntrantsWebSite.Models;

namespace BSUIREntrantsWebSite.Controllers
{
    public class EnrolleeController : Controller
    {
        private UniversityContext db = new UniversityContext();
        private static int count;
        private static int n;
        private static Timer timer;
        static EnrolleeController()
        {
            count = 0;
            n = 3;
            timer = new Timer(o => { count = 0; }, null, 0, 60000);
        }
        // GET: Enrollee
        public ActionResult Index()
        {
            return View(db.Entranst.ToList());
        }

        // GET: Enrollee/Details/5
        public ActionResult Details(int? id)
        {
            if(count == n)
            {
                return RedirectToAction("Index");
            }
            Interlocked.Increment(ref count);
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

        // GET: Enrollee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enrollee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,LastName,FirstName,HomeTown,TotalScore,BirthDate")] Enrollee enrollee)
        {
            if (ModelState.IsValid)
            {
                db.Entranst.Add(enrollee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enrollee);
        }

        // GET: Enrollee/Edit/5
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

        // POST: Enrollee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,LastName,FirstName,HomeTown,TotalScore,BirthDate")] Enrollee enrollee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enrollee);
        }

        // GET: Enrollee/Delete/5
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

        // POST: Enrollee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enrollee enrollee = db.Entranst.Find(id);
            db.Entranst.Remove(enrollee);
            db.SaveChanges();
            return RedirectToAction("Index");
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
