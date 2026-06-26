namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student students = new Student();
            string chooser = "1";
            while (chooser != "0")
            {
                Console.WriteLine("\n--- menu ---");
                Console.WriteLine("1. Print all students");
                Console.WriteLine("2. Add a student");
                Console.WriteLine("3. Find a student");
                Console.WriteLine("4. Update a student's score");
                Console.WriteLine("0. Exit");

                Console.WriteLine();
                Console.Write("Choose a number from menu: ");
                chooser = Console.ReadLine();

                switch (chooser)
                {
                    case "1":
                        students.PrintInfo();
                        break;
                    case "2":
                        students.StudentAdd();
                        break;
                    case "3":
                        students.FindStudent();
                        break;
                    case "4":
                        students.UpdateScore();
                        break;
                    case "0":
                        Console.WriteLine("Goodbye!");
                        break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }
    }
}
