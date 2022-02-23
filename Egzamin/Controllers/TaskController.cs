using Egzamin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Egzamin.Controllers
{
    public class TaskController : Controller
    {
        private static IList<TodoModel> zad = new List<TodoModel>()
        {
            new TodoModel(){ IdZad = 1, Nazwa = "zjedz banana", Opis ="10 rano", Zrob=false},
            new TodoModel(){ IdZad = 2, Nazwa = "zjedz jablko", Opis ="11 rano", Zrob=false},
            new TodoModel(){ IdZad = 3, Nazwa = "zjedz chleb", Opis ="12 rano", Zrob=false}
        };
        // GET: TaskController
        public ActionResult Index()
        {
            return View(zad);
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View(new TodoModel());
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TodoModel todoModel)
        {
            todoModel.IdZad = zad.Count + 1;

            zad.Add(todoModel);

            return RedirectToAction(nameof(Index));
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
