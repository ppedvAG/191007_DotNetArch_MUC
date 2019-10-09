using ppedv.LibertyBooks.Domain;
using ppedv.LibertyBooks.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ppedv.LibertyBooks.Data.XML
{
    public class XMLBookRepository : IBookRepository
    {
        public IEnumerable<Book> GetAll()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Book));
            FileStream stream = new FileStream("Books.xml", FileMode.Open);

            Book[] data = (Book[])serializer.Deserialize(stream);
            stream.Close();

            return data;
        }

        #region Ausgelassen: Simpel
        public void Delete(Book item)
        {
            throw new NotImplementedException();
        }



        public Book GetBookWithHighestPrice()
        {
            throw new NotImplementedException();
        }

        public Book GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int GetTotalAmountOfBooksInCirculation(Book input)
        {
            throw new NotImplementedException();
        }

        public void Insert(Book item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Book> Query()
        {
            throw new NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
