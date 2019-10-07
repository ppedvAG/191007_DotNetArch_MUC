using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspektorientierte_Programmierung
{
    // Typische Datenbankbefehle mit der Schnittstelle vereinheitlicht
    public interface IRepository // IComponent
    {
        void Insert<T>(T item);
        void Delete<T>(T item);
        void Update<T>(T item);
        T GetByID<T>(int ID);
        IEnumerable<T> GetAll<T>();
    }

    public enum User { ReadOnlyUser,User,Admin};
    public class AuthRepository : IRepository
    {
        public AuthRepository(IRepository parent,User currentUser)
        {
            this.parent = parent;
            this.currentUser = currentUser;
        }
        private IRepository parent;
        private User currentUser;

        private void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }


        public void Delete<T>(T item)
        {
            if (currentUser == User.Admin)
                parent.Delete(item);
            else
                Log($"Der aktuelle User {currentUser.ToString()} darf nicht löschen!");
        }

        public IEnumerable<T> GetAll<T>()
        {
            parent.GetAll<Person>();
            return null;
        }

        public T GetByID<T>(int ID)
        {
            parent.GetByID<Person>(ID);
            return default;
        }

        public void Insert<T>(T item)
        {
            if (currentUser == User.Admin || currentUser == User.User)
                parent.Insert(item);
            else
                Log("Der ReadOnlyUser darf kein Insert ausfüren !");
        }

        public void Update<T>(T item)
        {
            if (currentUser == User.Admin || currentUser == User.User)
                parent.Update(item);
            else
                Log("Der ReadOnlyUser darf kein Update ausfüren !");
        }
    }
}
