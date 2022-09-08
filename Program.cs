namespace OOP
{
    class Program
    {
        static void Main()
        {
            // Console.WriteLine($"{RadianToDegree(2*Math.PI)} == {RadianToDegree(0)} is {RadianToDegree(2*Math.PI) == RadianToDegree(0)}");
            // Console.WriteLine($"{DegreeToRadian(360)} == {DegreeToRadian(0)} is {DegreeToRadian(360) == DegreeToRadian(0)}");
            // PrintStars(5);
            // PrintStarsReverse(5);
            // StringSqrt();
            // GroupMembersArray();
            // GroupMembersList();
            
            static double RadianToDegree(double radian)
            {
                double degree = radian * 180 / Math.PI;
                return (degree);
            }
            static double DegreeToRadian(double degree)
            {
                double radian = degree * Math.PI / 180;
                return radian;
            }
            static void PrintStars(int i)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < j + 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
            static void PrintStarsReverse(int i)
            {
                for (int j = i; j > 0; j--)
                {
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }


            static void StringSqrt()
            // program doesnt let user enter input
            // debug
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                try
                {
                    int tal = int.Parse(input);
                    Console.WriteLine($"Squareroot: {Math.Sqrt(tal)}");
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                }
            }

            static void GroupMembersArray()
            {
                Console.Write("Enter number of group members: ");
                int n = int.Parse(Console.ReadLine());
                string[] group = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter name of group member");
                    group[i] = Console.ReadLine();
                }
                Console.WriteLine("Group members are: ");
                foreach (string name in group)
                {
                    Console.WriteLine(name);
                }
            }

            static void GroupMembersList()
            {
                List<string> group = new List<string>();
                int i = 0;
                Console.Write($"Enter name of group member #{i + 1} or hit enter to exit: ");
                string input = Console.ReadLine();
                while (input != "")
                {
                    i++;
                    group.Add(input);
                    Console.Write($"Enter name of group member #{i + 1} or hit enter to exit: ");
                    input = Console.ReadLine();
                }
                Console.WriteLine("Group members are: ");
                foreach (string name in group)
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}

