using System;
using System.Collections.Generic;

namespace K2_inheritance
{
    public abstract class PersonFilter
    {
        List<Person> filtered = new List<Person>();
        public abstract string FilterInfo();
        public void PrintNames()
        {
            Console.WriteLine($"Filtered by {FilterInfo()}");
            foreach(Person p in filtered)
            {
                Console.WriteLine(p.Name);
            }
        }
        public virtual void Filter(List<Person> plist) {
            foreach (Person person in plist)
            {
                if (FilterPredicate(person))
                {
                    filtered.Add(person);
                }
            }
        }
        public abstract bool FilterPredicate(Person person);
    }
}
