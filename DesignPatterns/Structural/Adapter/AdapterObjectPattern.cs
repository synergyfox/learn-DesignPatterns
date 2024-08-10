using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    /**
     * The Adapter Design Pattern is a structural pattern that allows objects
     * with incompatible interfaces to work together. It acts as a bridge between
     * two incompatible interfaces. This pattern is useful when you want to use existing 
     * classes, but their interfaces do not match the one you need.
     * 
     * The Adapter Design Pattern acts as a bridge between two incompatible objects.
     * Let’s say the first object is A and the second object is B. Object A wants to consume some 
     * of object B’s services. However, these two objects are incompatible and cannot communicate directly. 
     * In this case, the Adapter will come into the picture and act as a middleman or bridge between objects A and B.
     * Now, object A will call the Adapter, and the Adapter will do the necessary transformations or conversions, 
     * and then it will call object B.
     */

    

    #region Object Adapter Design Pattern
    #region Employee Class
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string designation, decimal salary)
        {
            ID = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }

    }
    #endregion
    #region Creating Adaptee

    public class ThirdPartyBillingSystem
    {
        //ThirdPartyBillingSystem accepts employee's information as a List to process each employee's salary
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
    #endregion
    #region Creating ITarget
    public interface ITarget
    {
      void ProcessCompanySalary(string[,] employeesArray);
    }
    #endregion
    #region Create Adapter
    public class EmployeeAdapter : ITarget
    {
        public void ProcessCompanySalary(string[,] employeesArray)
        {
           string Id = null;
           string Name = null;
           string Designation = null;
           string Salary = null;
           List<Employee> listEmployee = new List<Employee>();
           ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
              {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                     if (j == 0)
                     {
                          Id = employeesArray[i, j];
                     }
                     else if (j == 1)
                     {
                          Name = employeesArray[i, j];
                     }
                     else if (j == 2)
                     {
                          Designation = employeesArray[i, j];
                     }
                     else
                     {
                          Salary = employeesArray[i, j];
                     }
                }
                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
              }

            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            thirdPartyBillingSystem.ProcessSalary(listEmployee);

        }
    }
    #endregion
    #endregion

}
