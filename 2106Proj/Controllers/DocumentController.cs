using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _2106Proj.Models;
using _2106Proj.DAL;

namespace _2106Proj.Controllers
{
    public class DocumentController : Controller
    {
        public DocumentGateway DGateway = new DocumentGateway();
        public InterpreterGateway IGateway = new InterpreterGateway();
        // GET: Document
        public ActionResult Index()
        {
            return View();
        }

        // GET: Document
        public ActionResult Preview(string content)
        {
            InterpreterJob job = new InterpreterJob();
            job.Content = content;
            IGateway.JobReceiver(job, DGateway);
            ViewBag.Preview = DGateway.Preview;
            return View();
        }

        // GET: Document/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Document/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Document/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InterpreterJob job)
        {
            try
            {
                // TODO: Add insert logic here
                job.flag = 1;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Document/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Document/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, InterpreterJob job)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Document/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Document/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}