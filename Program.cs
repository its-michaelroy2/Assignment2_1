using Assignment2_1.Models;
using System.Data;
namespace Assignment2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 2_1
            //1.Write a class: “Student” with private data members: StudentId(int), StudentFname(string), StudentLname(string ), StudentGrade(char ) and public properties for each data member.Instantiate the class and assign data to properties.Display the data back on console.

            //Instantiate Student Class
            Student student = new Student();

            //Assign data to properties
            student.StudentId = 1;
            student.StudentFname = "Harry";
            student.StudentLname = "Potter";
            student.StudentGrade = 'W';

            //Display data
            Console.WriteLine("**Assignment 2_1**\n");
            Console.WriteLine("===============");
            Console.WriteLine(" Student Info: ");
            Console.WriteLine("===============\n");
            Console.WriteLine($"Student ID: {student.StudentId}");
            Console.WriteLine($"First Name: {student.StudentFname}");
            Console.WriteLine($"Last Name: {student.StudentLname}");
            Console.WriteLine($"Student Grade: {student.StudentGrade}");

            Console.WriteLine("\nPress ENTER to continue to Assignment 2_1_2");
            Console.ReadLine();


            //Assignment 2_1_2
            Model myCar = new Model("Beetle", 1983, "VW", "Gasoline");

            Console.Clear();
            Console.WriteLine("**Assignment 2_1_2**\n");
            Console.WriteLine("========================");
            Console.WriteLine(" Vehicle Class Example: ");
            Console.WriteLine("========================\n");

            Console.WriteLine($"Type: {myCar.VehicleType}");
            Console.WriteLine($"Wheels: {myCar.NumberOfWheels}");
            Console.WriteLine($"Fuel: {myCar.FuelType}");
            Console.WriteLine($"Brand: {myCar.BrandName}");
            Console.WriteLine($"Model: {myCar.ModelName}");
            Console.WriteLine($"Year: {myCar.Year}");

            Console.WriteLine("\nPress ENTER to continue to Assignment 2_1_3");
            Console.ReadLine();

            //Assignment 2_1_3
            string proceed;
            do
            {
                Console.Clear();
                Console.WriteLine("**Assignment 2_1_3**\n");
                Console.WriteLine("========================");
                Console.WriteLine(" Math Class Operations: ");
                Console.WriteLine("========================\n");

                Console.WriteLine("1. Add two integers");
                Console.WriteLine("2. Add three decimals");
                Console.WriteLine("3. Multiply two floats");
                Console.WriteLine("4. Multiply three floats");
                Console.Write("\nEnter your choice (1-4): ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter first integer: ");
                        int firstInt = int.Parse(Console.ReadLine());
                        Console.Write("Enter second integer: ");
                        int secondInt = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.Add(firstInt, secondInt)}");
                        break;

                    case 2:
                        Console.Write("Enter first decimal: ");
                        decimal firstDecimal = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter second decimal: ");
                        decimal secondDecimal = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter third decimal: ");
                        decimal thirdDecimal = decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.Add(firstDecimal, secondDecimal, thirdDecimal)}");
                        break;

                    case 3:
                        Console.Write("Enter first float: ");
                        float firstFloat = float.Parse(Console.ReadLine());
                        Console.Write("Enter second float: ");
                        float secondFloat = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.Multiply(firstFloat, secondFloat)}");
                        break;

                    case 4:
                        Console.Write("Enter first float: ");
                        float thirdFloat = float.Parse(Console.ReadLine());
                        Console.Write("Enter second float: ");
                        float fourthFloat = float.Parse(Console.ReadLine());
                        Console.Write("Enter third float: ");
                        float fifthFloat = float.Parse(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.Multiply(thirdFloat, fourthFloat, fifthFloat)}");
                        break;
                }

                Console.WriteLine("\nDo you want to continue? (y/n)");
                proceed = Console.ReadLine().ToLower();
            } while (proceed == "y");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(intercept: true);
        }
    }

    class Student
    {
        public int StudentId { get; set; }
        public string StudentFname { get; set; }
        public string StudentLname { get; set; }
        public char StudentGrade { get; set; }
    }

}
