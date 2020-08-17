using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UsedVehicleSystem.Models;

namespace UsedVehicleSystem.Controllers
{
    public class VehiclesController : Controller
    {
        private UsedVehicleSystemEntities db = new UsedVehicleSystemEntities();

        // GET: Vehicles
        public ActionResult Index()
        {
            var vehicles = db.Vehicles.Include(v => v.Make).Include(v => v.VehicleModel);
            return View(vehicles.ToList());
        }

        // GET: Vehicles/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            ViewBag.MakeId = new SelectList(db.Makes, "MakeId", "Name");
            ViewBag.ModelId = new SelectList(db.VehicleModels, "ModelId", "ModelName");
            return View();
        }

        // POST: Vehicles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VehicleId,MakeId,ModelId,Year,Price,Cost,SoldDate,CreateDate,EditDate")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine(vehicle.SoldDate);

                vehicle.CreateDate = DateTime.Now;
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MakeId = new SelectList(db.Makes, "MakeId", "Name", vehicle.MakeId);
            ViewBag.ModelId = new SelectList(db.VehicleModels, "ModelId", "ModelName", vehicle.ModelId);
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            ViewBag.MakeId = new SelectList(db.Makes, "MakeId", "Name", vehicle.MakeId);
            ViewBag.ModelId = new SelectList(db.VehicleModels, "ModelId", "ModelName", vehicle.ModelId);
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VehicleId,MakeId,ModelId,Year,Price,Cost,SoldDate,CreateDate,EditDate")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                vehicle.EditDate = DateTime.Now;
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MakeId = new SelectList(db.Makes, "MakeId", "Name", vehicle.MakeId);
            ViewBag.ModelId = new SelectList(db.VehicleModels, "ModelId", "ModelName", vehicle.ModelId);
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            db.Vehicles.Remove(vehicle);
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
