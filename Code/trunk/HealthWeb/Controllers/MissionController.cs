using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthWeb.Models;

namespace HealthWeb.Controllers
{
    public class MissionController : Controller
    {
        private MarsMissionContext db = new MarsMissionContext();

        //
        // GET: /Mission/

        public ActionResult Index()
        {
            try
            {
                return View(db.Missions.ToList());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //
        // GET: /Mission/Details/5

        public ActionResult Details(int id = 0)
        {
            Mission mission = db.Missions.Find(id);
            if (mission == null)
            {
                return HttpNotFound();
            }
            return View(mission);
        }

        //
        // GET: /Mission/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Mission/Create

        [HttpPost]
        public ActionResult Create(Mission mission)
        {
            if (ModelState.IsValid)
            {
                db.Missions.Add(mission);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mission);
        }

        //
        // GET: /Mission/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Mission mission = db.Missions.Find(id);
            if (mission == null)
            {
                return HttpNotFound();
            }
            return View(mission);
        }

        //
        // POST: /Mission/Edit/5

        [HttpPost]
        public ActionResult Edit(Mission mission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mission);
        }

        //
        // GET: /Mission/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Mission mission = db.Missions.Find(id);
            if (mission == null)
            {
                return HttpNotFound();
            }
            return View(mission);
        }

        //
        // POST: /Mission/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Mission mission = db.Missions.Find(id);
            db.Missions.Remove(mission);
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