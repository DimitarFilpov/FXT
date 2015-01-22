using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FXTrader.Model;
using FXTrader.Service;

namespace FXTrader.Controllers
{
    public class PairController : Controller
    {
        IPairService _pairService;
        public PairController(IPairService pairService)
        {
            _pairService = pairService;
        }

        private FXTraderContext db = new FXTraderContext();

        // GET: /Pair/
        public ActionResult Index()
        {
            
            return View(_pairService.GetAll());
        }

        // GET: /Pair/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pair pair = db.Pairs.Find(id);
            if (pair == null)
            {
                return HttpNotFound();
            }
            return View(pair);
        }

        // GET: /Pair/Create
        public ActionResult Create()
        {
            ViewBag.CurrencyId = new SelectList(db.Currencies, "Id", "Title");
            return View();
        }

        // POST: /Pair/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Title,Commission,Miltiplier,Increment,MaxChange,CurrencyId")] Pair pair)
        {
            if (ModelState.IsValid)
            {
                _pairService.Create(pair);
                return RedirectToAction("Index");
            }

            ViewBag.CurrencyId = new SelectList(db.Currencies, "Id", "Title", pair.CurrencyId);
            return View(pair);
        }

        // GET: /Pair/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pair pair = _pairService.GetById(id.Value);
            if (pair == null)
            {
                return HttpNotFound();
            }
            ViewBag.CurrencyId = new SelectList(db.Currencies, "Id", "Title", pair.CurrencyId);
            return View(pair);
        }

        // POST: /Pair/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Title,Commission,Miltiplier,Increment,MaxChange,CurrencyId")] Pair pair)
        {
            if (ModelState.IsValid)
            {
                _pairService.Update(pair);
                
                return RedirectToAction("Index");
            }
            ViewBag.CurrencyId = new SelectList(db.Currencies, "Id", "Title", pair.CurrencyId);
            return View(pair);
        }

        // GET: /Pair/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pair pair = _pairService.GetById(id.Value);
            if (pair == null)
            {
                return HttpNotFound();
            }
            return View(pair);
        }

        // POST: /Pair/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pair pair = _pairService.GetById(id);
            _pairService.Delete(pair);
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
