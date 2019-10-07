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
}
