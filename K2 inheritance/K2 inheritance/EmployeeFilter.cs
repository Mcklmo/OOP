using System;

namespace K2_inheritance
{
    class EmployeeFilter : PersonFilter {
        public override string FilterInfo()
        {
            return ("Employee");
        }
        public override bool FilterPredicate(Person person)
        {
            //Console./*WriteLine*/($"{person.Name} {person.GetType()}");
            return person.GetType() == typeof(Employee);
        }
    }
}
