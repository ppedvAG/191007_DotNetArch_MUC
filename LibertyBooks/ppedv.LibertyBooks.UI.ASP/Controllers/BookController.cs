using ppedv.LibertyBooks.Data.EF;
using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ppedv.LibertyBooks.UI.ASP.Controllers
{
    public class BookController : Controller
    {
        public BookController()
        {
            core = new Core(new EFUnitOfWork(new EFContext()));
        }
        private Core core;

        // GET: Book
        public ActionResult Index()
        {
            return View(core.GetAllBooks());
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            var book = core.GetAllBooks().First(x => x.ID == id);
            return View(book);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View(new Book { Title = "NEUES BUCH", Author = "Max Mustermann" });
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book createdBook)
        {
            try
            {
                core.UoW.BookRepository.Insert(createdBook);
                core.UoW.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            //var book = core.GetAllBooks().First(x => x.ID == id);
            return View(core.UoW.BookRepository.GetByID(id));
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book editedBook)
        {
            try
            {
                // TODO: Add update logic here
                core.UoW.BookRepository.Update(editedBook);
                core.UoW.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View(core.UoW.BookRepository.GetByID(id));
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Book bookToDelete)
        {
            try
            {
                var loadedBook = core.UoW.BookRepository.GetByID(id); // es kann ja sein, dass das buch schon gelöscht wurde
                if(loadedBook!= null)
                {
                    core.UoW.BookRepository.Delete(loadedBook);
                    core.UoW.Save();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
