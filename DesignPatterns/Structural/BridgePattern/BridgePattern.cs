using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.BridgePattern
{
    public interface Presistence { 
    
        public void SaveData(string data);
        public void DeleteData(int id);  
        public void UpdateData(int id, string data);
    } 

    public class FilePersistence : Presistence
    {
        public void DeleteData(int id)
        {
            Console.WriteLine("Data deleted from file");
        }

        public void SaveData(string data)
        {
            Console.WriteLine("Data saved to file");
        }

        public void UpdateData(int id, string data)
        {
            Console.WriteLine("Data updated in file");
        }
    }

    public class DatabasePersistence : Presistence
    {
        public void DeleteData(int id)
        {
            Console.WriteLine("Data deleted from database");
        }

        public void SaveData(string data)
        {
            Console.WriteLine("Data saved to database");
        }

        public void UpdateData(int id, string data)
        {
            Console.WriteLine("Data updated in database");
        }
    }


    public abstract class PersistenceImplementor
    { 
        protected Presistence _presistence;
        public abstract void SaveData(string data);
        public abstract void DeleteData(int id);
        public abstract void UpdateData(int id, string data);    
    }



    public class FilePersistenceImplementor : PersistenceImplementor
    {
        public FilePersistenceImplementor()
        {
            _presistence = new FilePersistence();
        }
        public override void DeleteData(int id)
        {
            _presistence.DeleteData(id);
        }

        public override void SaveData(string data)
        {
            _presistence.SaveData(data);
        }

        public override void UpdateData(int id, string data)
        {
            _presistence.UpdateData(id, data);
        }
    }

    public class DatabasePersistenceImplementor : PersistenceImplementor
    {
        public DatabasePersistenceImplementor()
        {
            _presistence = new DatabasePersistence();
        }
        public override void DeleteData(int id)
        {
            _presistence.DeleteData(id);
        }

        public override void SaveData(string data)
        {
            _presistence.SaveData(data);
        }

        public override void UpdateData(int id, string data)
        {
            _presistence.UpdateData(id, data);
        }
    }

}
