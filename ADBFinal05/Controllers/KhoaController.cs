using ADBFinal05.App_Start;
using ADBFinal05.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADBFinal05.Controllers
{
    public class KhoaController : Controller
    {
        private MongoDBContent dbContent;
        private IMongoCollection<KhoaModel> khoaCollection;

        public KhoaController()
        {
            dbContent = new MongoDBContent();
            khoaCollection = dbContent.database.GetCollection<KhoaModel>("Khoa");
        }

        // GET: Khoa
        public ActionResult Index()
        {
            List<KhoaModel> khoas = khoaCollection.AsQueryable<KhoaModel>().ToList();
            return View(khoas);
        }

        // GET: Khoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Khoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Khoa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Khoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Khoa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Khoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Khoa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
