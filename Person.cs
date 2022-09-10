
namespace OOP
{
    class Person
    {
        public Person(string FirstName,string LastName,int Age)
        {
            this.FirstName=FirstName;
            this.LastName=LastName;
            this.Age=Age;
            this.PersonId=Guid.NewGuid();
        }
        public string ShowId()
        {
            return this.PersonId.ToString();
        }
        Guid PersonId;
        private string _firstname;
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name must be at least 2 characters long");
                }

                _firstname = value;
            }
        }
        string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Last name must be at least 2 characters long");
                }
                _lastName = value;
            }
        }
        private int _age;
        public int Age
        {
            get
            {
                return _age;

            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Age cannot be negative");
                }
                if (value > 150)
                {
                    throw new Exception("Age cannot be over 150");
                }
                _age = value;
            }
        }
        public Person Far;
        public Person Mor;
    }
}

