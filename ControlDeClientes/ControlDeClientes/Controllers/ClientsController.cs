using ControlDeClientes.Helpers;
using ControlDeClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlDeClientes.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Client Control Stage";
            return View(Storage.Instance.ClientsList);
        }
        public ActionResult ClientsFilter()
        {
            return View(Storage.Instance.ClientsList);
        }
        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            ViewBag.Message = "Welcome to Create Stage";
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var Client = new ClientsModel
                {
                    Name = collection["name"],
                    LastName = collection["LastName"],
                    Phone = int.Parse(collection["Phone"]),
                    Description = collection["Description"]
                };

                if (Client.Save())
                {
                    return RedirectToAction("Index");
                }else
                {
                    return View(Client);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clients/Edit/5
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

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clients/Delete/5
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
