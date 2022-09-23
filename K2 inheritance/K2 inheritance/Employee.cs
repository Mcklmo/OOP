using System;
using System.Reflection.Emit;
using System.Security.Policy;

namespace K2_inheritance
{
    public class Employee : Person
    {
        //2. Write a class to represent an employee. An employee has a name, job title and a salary. Write a
        //subclass to represent a manager.A manager has a yearly bonus bonus.
        //a.Add appropriate constructors for the classes.Discuss in the group what appropriate
        //means
        //b. Employee has a method CalculateYearlySalary; implement this
        //c.For manager, CalculateYearlySalary includes bonus
        //d. Employe-and managers has seneniority levels 1-10, each level results in 10% extra
        //salary. Level 3 is 30%, level 7 is 70% extra.Bonus is not affected by seniority levels.
        public Employee(string name,int age,string jobTitle,double salary,double seneniorityLevel):
            base(name,age)
        {
            JobTitle = jobTitle;
            Salary = salary;
            SeneniorityLevel = seneniorityLevel /10+1;
            YearlySalary = Salary * 12 * SeneniorityLevel;
        }
        protected string Name;
        protected string JobTitle;
        protected double Salary;
        protected double SeneniorityLevel;
        protected double YearlySalary;
        public virtual double CalculateYearlySalary()
        {
            return YearlySalary;
        }

    }
}
