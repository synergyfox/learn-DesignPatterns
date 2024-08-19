namespace DesignPatterns.Behavioral.Iterator
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }

    //Concrete Collection

    class EmlployeesCollection : IAbstractCollection
    {        
        private List<Employee> listEmployees = new List<Employee>();
        
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

     
        public int Count
        {
            get { return listEmployees.Count; }
        }
     
        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }
        
        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }

    interface IAbstractCollection
    {        
        Iterator CreateIterator();
    }
    interface IAbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }

    class Iterator : IAbstractIterator
    {        
        private EmlployeesCollection Collection;
        private int Current = 0;     
        private readonly int Step = 1;
        
        public Iterator(EmlployeesCollection Collection)
        {        
            this.Collection = Collection;
        }
        
        public Employee First()
        {
            
            Current = 0;
            return Collection.GetEmployee(Current);
        }        
        public Employee Next()
        {
            
            Current += Step;
            if (!IsCompleted)
            {
                return Collection.GetEmployee(Current);
            }
            else
            {
                return null;
            }
        }
        
        public bool IsCompleted
        {        
            get { return Current >= Collection.Count; }
        }
    }

}
