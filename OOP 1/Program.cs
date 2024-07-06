namespace OOP_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            string[] weekDays=  Enum.GetNames(typeof(WeekDays));

            foreach (string weekDay in weekDays) 
            {
                Console.WriteLine($"{weekDay}");
            }
            #endregion

            #region 2

            Person[] people = {new Person("Mina",26),new Person("Michael",26),new Person("Katrin",25)};
            foreach (Person person in people) 
            {
                Console.WriteLine($"Person Name is {person.Name} and hes at {person.Age}");
            }

            #endregion

            #region 3

            Console.Write("Enter a season (Spring, Summer, Autumn, or Winter): ");
            string input = Console.ReadLine();
            Season inputSeason;
            do { Console.WriteLine("Invalid input. Please enter a valid season."); } 
            while(!Enum.TryParse(input, true, out inputSeason));
            
                switch (inputSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring months: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer months: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn months: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter months: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season input. Please enter a valid season.");
                        break;
                }
            #endregion

            #region 4
            Permissions userPermissions = Permissions.Read | Permissions.Write;
            userPermissions |= Permissions.Delete;
            userPermissions |= Permissions.Execute;
            userPermissions &= ~Permissions.Execute;

            bool hasPermission=(userPermissions & Permissions.Execute) == Permissions.Execute  ? true : false;
            // it should return False
            #endregion

            #region 5
            Console.Write("Enter a color (Red, Green, or Blue): ");
            input = Console.ReadLine();
            Colors inputColor;
            do { Console.WriteLine("Invalid input. Please enter a valid color."); }
            while (!Enum.TryParse(input, true, out inputColor));

            switch (inputColor)
            {
                case Colors.Red:
                    Console.WriteLine($"{input} is a primary color!");
                    break;
                case Colors.Green:
                    Console.WriteLine($"{input} is a primary color!");
                    break;
                case Colors.Blue:
                    Console.WriteLine($"{input} is a primary color!");
                    break;
                default:
                    Console.WriteLine($"{input} is not a primary color.");
                    break;
            }
            #endregion

            #region 6

            #region point1 ,Point2
            double inputPoint=0.00;
            
            Point P1 =new Point();
            Console.WriteLine("Enter coordinates for Point 1:");
            Console.Write("X1: ");
            input = Console.ReadLine();
            do { Console.WriteLine("Invalid input. Please enter a valid number."); }
            while (!double.TryParse(input,out inputPoint));
            P1.X = inputPoint;

            Console.Write("Y1: ");
            input = Console.ReadLine();
            do { Console.WriteLine("Invalid input. Please enter a valid number."); }
            while (!double.TryParse(input, out inputPoint));
            P1.Y = inputPoint;

            Point P2 = new Point();
            Console.WriteLine("Enter coordinates for Point 2:");
            Console.Write("X2: ");
            input = Console.ReadLine();
            do { Console.WriteLine("Invalid input. Please enter a valid number."); }
            while (!double.TryParse(input, out inputPoint));
            P2.X = inputPoint;

            Console.Write("Y2: ");
            input = Console.ReadLine();
            do { Console.WriteLine("Invalid input. Please enter a valid number."); }
            while (!double.TryParse(input, out inputPoint));
            P2.Y = inputPoint;


            #endregion

            double distance = CalculateDistance(P1, P2);
            Console.WriteLine($"Distance between Point 1 and Point 2: {distance:F2}");
            #endregion

            #region 7

            Person person1 = new Person();
            person1.Name=default;
            person1.Age = default;
            int counter = 0;int age=0;string name = "";
            do
            {
                Console.Write($"Enter name for person {counter + 1}: ");
                name = Console.ReadLine();

                Console.Write($"Enter Age for person {counter + 1}: ");
                int.TryParse(Console.ReadLine(),out age);

                if (age > 0 && age>person1.Age)
                {
                    person1.Age=age;
                    person1.Name=name;
                }
                counter++;
            } while ((counter < 3 && age == 0) || (person1.Name is default(string) && person1.Age is default(int)) );
           
            Console.WriteLine($"The oldest person is {person1.Name} ({person1.Age} years old).");

            #endregion
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            double DeffX = p2.X - p1.X;
            double DeffY = p2.Y - p1.Y;
            return Math.Sqrt(DeffX * DeffX + DeffY * DeffY);
        }
    }



    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    
    [Flags]
    enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    enum Colors
    {
        Red,
        Green,
        Blue
    }
}
