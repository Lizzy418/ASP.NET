using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using WebApp2.Context;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    public class myTicketsController : Controller
    {
        private tkData db = new tkData();

        // GET: myTickets
        public ActionResult Index(string idCode, string searchString)
        {
            var idCodeLst = new List<string>();

            var idCodeQry = from d in db.myTickets
                           orderby d.Date ascending
                           select d.Code;

            idCodeLst.AddRange(idCodeQry.Distinct());
            ViewBag.idCode = new SelectList(idCodeLst);

            var titles = from t in db.myTickets select t;

            titles = titles.Where(x => x.Code == idCode);

            if (!string.IsNullOrEmpty(searchString))
            {
                titles = titles.Where(s => s.Title.Contains(searchString));
            }
            //return View(db.myTickets.ToList());
            return View(titles);
        }

        // GET: myTickets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            myTicket myTicket = db.myTickets.Find(id);
            if (myTicket == null)
            {
                return HttpNotFound();
            }
            return View(myTicket);
        }

        // GET: myTickets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: myTickets/Create
        // 초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        // 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Date,Title,Theater,Actors,Seats,Site,Price")] myTicket myTicket)
        {            
            if (ModelState.IsValid)
            {
                db.myTickets.Add(myTicket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myTicket);
        }

        // GET: myTickets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            myTicket myTicket = db.myTickets.Find(id);
            if (myTicket == null)
            {
                return HttpNotFound();
            }
            return View(myTicket);
        }

        // POST: myTickets/Edit/5
        // 초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        // 자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Date,Title,Theater,Actors,Seats,Site,Price")] myTicket myTicket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myTicket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myTicket);
        }

        // GET: myTickets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            myTicket myTicket = db.myTickets.Find(id);
            if (myTicket == null)
            {
                return HttpNotFound();
            }
            return View(myTicket);
        }

        // POST: myTickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            myTicket myTicket = db.myTickets.Find(id);
            db.myTickets.Remove(myTicket);
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
