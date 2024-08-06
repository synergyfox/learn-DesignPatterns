using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class GymCoach
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int ExperienceYears { get; set; }

        public abstract GymCoach GetClone();
        public abstract void ShowStats();

    }

    public class SeniorGymCoach : GymCoach
    {
      public int Salary { get; set; }

        public override GymCoach GetClone()
        {
            return (GymCoach)this.MemberwiseClone();
        }

        public override void ShowStats()
        {
            Console.WriteLine("Name: " + Name + "\n");
            Console.WriteLine("Age: " + Age + "\n");
            Console.WriteLine("Experience Years: " + ExperienceYears + "\n");
            Console.WriteLine("Salary: " + Salary + "\n");
        }
    }

    public class JuniorGymCoach : GymCoach
    {
      
        public int FixedAmount { get; set; }

        public override GymCoach GetClone()
        {
            return (GymCoach)this.MemberwiseClone();
        }

        public override void ShowStats()
        {
            Console.WriteLine("Name: " + Name + "\n");
            Console.WriteLine("Age: " + Age + "\n");
            Console.WriteLine("Experience Years: " + ExperienceYears + "\n");
            Console.WriteLine("Fixed Amount: " + FixedAmount + "\n");
        }
    }
}
