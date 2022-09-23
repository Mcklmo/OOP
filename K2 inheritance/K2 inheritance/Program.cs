using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace K2_inheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Ex5();
            //Ex4();
            //Ex3();
            //Ex2();
            //Ex1();
            void Ex5()
            {
                List<Person> plist = new List<Person>();
                plist.Add(new Person("Thomas", 19));
                plist.Add(new Person("Erik", 22));
                plist.Add(new Employee("Thomas", 22, "CEO", 30000, 0));
                plist.Add(new Employee("Hans", 23, "CTO", 20000, 0));
                plist.Add(new Person("Kurt", 12));
                NameFilter();
                PersonFilter ageFilter=AgeFilter();
                PersonFilter employeeFilter=EmployeeFilter();
                PersonFilter notEmployeeFilter=NotFilter(employeeFilter);
                PersonFilter not22Filter = NotFilter(ageFilter);
                AndFilter(ageFilter, employeeFilter);
                AndFilter(notEmployeeFilter, ageFilter);
                void AndFilter(PersonFilter filter1, PersonFilter filter2)
                {
                    PersonFilter andFilter = new AndFilter(filter1, filter2);
                    andFilter.Filter(plist);
                    andFilter.PrintNames();
                }

                PersonFilter NotFilter(PersonFilter Filter)
                {
                    PersonFilter notFilter = new NotFilter(Filter);
                    notFilter.Filter(plist);
                    notFilter.PrintNames();
                    return notFilter;
                }

                void NameFilter()
                {
                    PersonFilter filter = new NameFilter("Thomas");
                    filter.Filter(plist);
                    filter.PrintNames();
                }

                PersonFilter AgeFilter()
                {
                    PersonFilter filter = new AgeFilter(22);
                    filter.Filter(plist);
                    filter.PrintNames();
                    return filter;
                }
                PersonFilter EmployeeFilter()
                {
                    PersonFilter filter = new EmployeeFilter();
                    filter.Filter(plist);
                    filter.PrintNames();
                    return filter;
                }
            }
            void Ex4()
            {
                BankAccount acc = new BankAccount();
                
                Console.WriteLine("Enter 1 to deposit or 2 to withdraw, 0 to exit: ");
                double input = double.Parse(Console.ReadLine());
                while (input != 0)
                {
                    Console.WriteLine("Enter amount: ");
                    switch (input)
                    {
                        case 1:
                            acc.Deposit(double.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            acc.Withdraw(double.Parse(Console.ReadLine()));
                            break;
                    }
                    Console.WriteLine($"Current balance: {acc.GetBalance()}");
                    Console.WriteLine("Enter 1 to deposit or 2 to withdraw, 0 to exit: ");
                    input = double.Parse(Console.ReadLine());
                }
            }
            void Ex3()
            {
                ParkingWeekday weekday = new ParkingWeekday(10);
                ParkingWeekend weeknd = new ParkingWeekend(10);
                Console.WriteLine(weekday.Minutes);
                Console.WriteLine(weeknd.Minutes);
            }
            void Ex2()
            {
                Manager man = new Manager("John",18, "CEO", 20000,5,0);
                Employee em = new Employee("John", 18, "CEO",20000,0);
                Employee em1 = new Employee("John", 18, "CEO", 20000,1);
                Console.WriteLine(em1.CalculateYearlySalary());
                Console.WriteLine(man.CalculateYearlySalary());
                Console.WriteLine(em.CalculateYearlySalary());
            }
            void Ex1()
            {
                PrivateStuff CantAcess = new PrivateStuff();
                //Console.WriteLine(CantAcess.isPrivate);
            }
        }
    }
}
