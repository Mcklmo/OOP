namespace OOP
{
    class PersonPrinter
    {
        public void PrintPerson(Person p)
        {
            Console.WriteLine($"{p.FirstName} {p.LastName} is {p.Age} years old");
        }
        public void PrintFamilyTree(Person p)
        {
            PrintPerson(p);
            if (p.Far != null)
            {
                PrintFamilyTree(p.Far);
            }
            if (p.Mor != null)
            {
                PrintFamilyTree(p.Mor);
            }
        }
    }
}


