using System;
using System.Collections.Generic;

namespace K2_inheritance
{
    public class NameFilter : PersonFilter
    {
        public override string FilterInfo()
        {
            return $"Name == {Name}";
        }
        public NameFilter(string name)
        { 
            Name = name;
        }
        protected string Name;
        public override bool FilterPredicate(Person person)
        {
            return person.Name == Name;
        }
    }
}
