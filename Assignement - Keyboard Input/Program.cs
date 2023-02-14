namespace Assignement___Keyboard_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Greetings
            string name;
            int age;
            DateTime currentYear = DateTime.Today;
            int yearNow = currentYear.Year;

            Console.WriteLine("Greetings, please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Please now enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Congratulations " + Convert.ToString(name) + ", on being born in " + Convert.ToString(yearNow - age) + "!");
            Console.WriteLine();
            Console.WriteLine();


            // 2. Adder
            double num1, num2, num3;

            Console.WriteLine("Please enter 3 numbers in each line. Press ENTER after you have written each number individually:");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double sum = num1 + num2 + num3;

            Console.WriteLine("The sum of the numbers you entered is " + sum);

           // 3.Distance

            double length1, length2, length3;
            Console.WriteLine("Please enter 3 distances in kilometers (include only the magnitude, not the unit). Press enter after you've entered EACH number:");
            length1 = Convert.ToDouble(Console.ReadLine());
            length2 = Convert.ToDouble(Console.ReadLine());
            length3 = Convert.ToDouble(Console.ReadLine());
            double lengthAverage = (length1 + length2 + length3) / 3;

            Console.WriteLine();
            Console.WriteLine("The average distance of the three you entered is " + Math.Round(lengthAverage, 2));

            // 4.Hypotenuse

            double triLength1, triLength2, hypotenuse;
            Console.WriteLine("Please enter 2 side lengths of your right angle triangle. Press ENTER after entering each length:");
            Console.WriteLine();
            triLength1 = Convert.ToDouble(Console.ReadLine());
            triLength2 = Convert.ToDouble(Console.ReadLine());
            hypotenuse = Math.Sqrt(Math.Pow(triLength1, 2) + Math.Pow(triLength2, 2));

            Console.WriteLine();
            Console.WriteLine("The hypotenuse of your triangle is " + hypotenuse);


        }
    }
}