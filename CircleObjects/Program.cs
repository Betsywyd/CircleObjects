namespace CircleObjects
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Circle Tester");
            double r = RadiusEnter();
            Console.WriteLine("Enter radius:" +r);
            bool grow = true;
            do
            {
                Circle objCircle = new Circle(r);
                double diameter = objCircle.Diameter();
                double circumference = objCircle.Circumference();
                double area = objCircle.Area();
                Console.WriteLine("Diameter: " + diameter);
                Console.WriteLine("Circumference: " + circumference);
                Console.WriteLine("Area: " + area);

                bool continueGrow = ContinueGrow();
                if (continueGrow)
                {
                    r = objCircle.Grow(r);
                    continue;
                }
                else if (continueGrow==false)
                {
                    Console.WriteLine("Goodbye. The circle’s final radius is " + r);
                    grow = false;
                }
            }while (grow);
        }

    public static double RadiusEnter()
        {
                try
                {
                    Console.WriteLine("Please input radius: ");
                    double r = double.Parse(Console.ReadLine());
                    return r;
                }
                catch (Exception)
                {
                    //Console.WriteLine(e.Message);
                    Console.WriteLine("That was not a valid input, let's try that again");
      
                return RadiusEnter();
                }
        }

        public static bool ContinueGrow()
        {
            bool grow = true;
            do { 
            Console.WriteLine("Should the circle grow? (y/n)");
            string answer = Console.ReadLine().ToLower().Trim();
            if (answer == "y")
            { 
               return true;

            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input,let's try again!");
                return ContinueGrow();
            }
            }while( grow );
        }
    }
}