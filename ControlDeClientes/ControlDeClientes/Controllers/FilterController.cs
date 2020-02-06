using System;
using System.Collections.Generic;
using ControlDeClientes.Models;
using ControlDeClientes.Helpers;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlDeClientes.Controllers
{
    public class FilterController : Controller
    {
        // GET: Filter
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SortName()
        {
            return View(Storage.Instance.ClientsSortedByName);
        }

        public ActionResult SortLastName()
        {
            return View(Storage.Instance.ClientsSortedByLastName);
        }

        // GET: Filter/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Filter/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: Filter/Create
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            try
            {
                var FilterData = new FilterModel
                {
                    TypeSort = collection["TypeSort"]
                };

                if (FilterData.Save())
                {
                    string TypeOfSort = Storage.Instance.Type;

                    switch (TypeOfSort)
                    {
                        case "SortName":
                            var AnonymousClient = new ClientsModel();
                                if (AnonymousClient.SortName())
                                {
                                    return RedirectToAction("SortName");
                                }
                        break;

                        case "SortLastName":
                            var AnonymousSecondClient = new ClientsModel();
                            if (AnonymousSecondClient.SortLastName())
                            {
                                return RedirectToAction("SortLastName");
                            }

                        break;
                    }
                }
                
              
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Filter/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Filter/Edit/5
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

        // GET: Filter/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Filter/Delete/5
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
