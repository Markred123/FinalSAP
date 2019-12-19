using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClassroomBooking.Models;

namespace ClassroomBooking.Controllers
{
    public class cRoomsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: cRooms
        public ActionResult Index()
        {
            return View(db.cRooms.ToList());
        }

        // GET: cRooms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cRoom cRoom = db.cRooms.Find(id);
            if (cRoom == null)
            {
                return HttpNotFound();
            }
            return View(cRoom);
        }

        // GET: cRooms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cRooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cRoomID,roomName,studentName,studentEmail,studentPhone,cRoomDate,cRoomDateTo")] cRoom cRoom)
        {
            if (ModelState.IsValid)
            {
                db.cRooms.Add(cRoom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cRoom);
        }

        // GET: cRooms/Edit/5
        public ActionResult Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                cRoom cRoom = db.cRooms.Find(id);
                if (cRoom == null)
                {
                    return HttpNotFound();
                }
                return View(cRoom);
            }
            catch
            {
                return null;
            }
        }   

        // POST: cRooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cRoomID,roomName,studentName,studentEmail,studentPhone,cRoomDate,cRoomDateTo")] cRoom cRoom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cRoom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cRoom);
        }

        // GET: cRooms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cRoom cRoom = db.cRooms.Find(id);
            if (cRoom == null)
            {
                return HttpNotFound();
            }
            return View(cRoom);
        }

        // POST: cRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cRoom cRoom = db.cRooms.Find(id);
            db.cRooms.Remove(cRoom);
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
