using Centisoft.Core.Contracts;
using Centisoft.Core.DAL;
using Centisoft.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentisoftWeb.Controllers
{
    public class DeveloperController : Controller
    {
        public IDeveloperFacade developerFacade;
        public DeveloperController(IDeveloperFacade developerFacade)
        {
            this.developerFacade = developerFacade;
        }
        // GET: Developer
        public ActionResult Index()
        {
            Developer dev = new Developer
            {
                Name = "name", 
                AccountId = 1,
                Email = "MyMail@mail.dk"
            };
            developerFacade.CreateDeveloper(dev);

            return View();
        }

        // GET: Developer/Details/5
        public ActionResult Details(int id)
        {
            Developer dev = developerFacade.FindDeveloper(id);
            return View(dev);
        }

        // GET: Developer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Developer/Create
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

        // GET: Developer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Developer/Edit/5
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

        // GET: Developer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Developer/Delete/5
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
