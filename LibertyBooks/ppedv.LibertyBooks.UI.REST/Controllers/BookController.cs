using ppedv.LibertyBooks.Data.EF;
using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ppedv.LibertyBooks.UI.REST.Controllers
{
    public class BookController : ApiController
    {
        public BookController()
        {
            this.core = new Core(new EFUnitOfWork(new EFContext()));
        }
        private readonly Core core;

        // GetAllBooks
        // GetBook -> id
        // Custom-Befehle

        public IEnumerable<Book> GetAllBooks()
        {
            return core.GetAllBooks();
        }

        public IHttpActionResult GetBook(int id)
        {
            // ToDo: Gibt es diese ID ?
            var result = core.UoW.BookRepository.GetByID(id);
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }
    }
}
