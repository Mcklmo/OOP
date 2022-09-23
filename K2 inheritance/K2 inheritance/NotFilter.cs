using System;
using System.Collections.Generic;

namespace K2_inheritance
{
    class NotFilter : PersonFilter
    {
        public NotFilter(PersonFilter x)
        {
            _Filter = x;
        }
    
        PersonFilter _Filter;
        int Age;
        string Name;
        public override string FilterInfo()
        {
            return($"Not {_Filter.FilterInfo()}");
        }
        public override bool FilterPredicate(Person person)
        {
            return ! _Filter.FilterPredicate(person);
        }
    }
}
