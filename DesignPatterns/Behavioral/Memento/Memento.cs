using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class Employee
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public string  Designation { get; set; }

        public Employee(string Id, string Name, string Salary,string Designation)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
            this.Designation = Designation;
        }
        public string GetDetails()
        {
            return $"Employee [ID={Id} , Name={Name} , Salary={Salary}, Designation={Designation}]";
        }


    }

    public class Memento
    {
        public Employee employee { get; set; }
        
        public Memento(Employee _employee)
        {
            employee = _employee;
        }        
        public string GetDetails()
        {
            return "Memento [Employee=" + employee.GetDetails() + "]";
        }
    }
    public class Caretaker
    {
        private List<Memento> EmployeeList = new List<Memento>();
        
        public void AddMemento(Memento m)
        {
            EmployeeList.Add(m);
            Console.WriteLine("Employee snapshots Maintained by CareTaker :" + m.GetDetails());
        }
        
        public Memento GetMemento(int index)
        {
            return EmployeeList[index];
        }
    }

    public class Originator
    {
        public Employee employee;
        
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Originator: Setting State to Employee : " + employee.GetDetails());
            this.employee = memento.employee;
        }
        
        public Memento CreateMemento()
        {
            Console.WriteLine("Originator: Creating Memento");
            return new Memento(employee);
        }
        public string GetDetails()
        {            
            return "Originator [Employee=" + employee.GetDetails() + "]";
        }

    }



}
