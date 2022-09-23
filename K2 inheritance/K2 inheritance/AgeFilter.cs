using System;

namespace K2_inheritance
{
    class AgeFilter : PersonFilter 
    {
        public override string FilterInfo()
        {
            return ($"Age == {Age}");
        }
        public AgeFilter(int age)
        {
            Age = age;
        }
        protected int Age;
        public override bool FilterPredicate(Person person)
        {
            return person.Age == Age;
        }
    }
}
