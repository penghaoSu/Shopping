using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Web.Areas.Admin.Controllers
{
    public class ProductCateController : Controller
    {
        // GET: ProductCate
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductCate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductCate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductCate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductCate/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ProductCate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductCate/Delete/5
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