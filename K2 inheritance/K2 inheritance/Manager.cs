using System;

namespace K2_inheritance
{
    public class Manager : Employee
    {
        public Manager(string name,int age,string jobTitle,double salary,double seneniorityLevel, double bonus):
            base(name,age,jobTitle,salary, seneniorityLevel)
        {
            Bonus = bonus;
        }
        protected double Bonus;
        protected double yearlySalary;
        public override double CalculateYearlySalary()
        {
            return YearlySalary + Bonus;
        }
    }
}
