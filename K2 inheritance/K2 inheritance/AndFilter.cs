using System;

namespace K2_inheritance
{
    class AndFilter : PersonFilter 
    {
        public AndFilter(PersonFilter f1,PersonFilter f2)
        {
            Filter1 = f1;
            Filter2 = f2;
        }
        PersonFilter Filter1;
        PersonFilter Filter2;
        public override bool FilterPredicate(Person person)
        {
            return Filter1.FilterPredicate(person) && Filter2.FilterPredicate(person) ;
        }

        public override string FilterInfo()
        {
            return($"{Filter1.FilterInfo()} AND {Filter2.FilterInfo()}");
        }

    }
}
