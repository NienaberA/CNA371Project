using System;

namespace CNA371
{
    class Program
    {
        private static string name = "";
        private static string surname = "";
        private static string email = "";
        private static double mathsMarks = 0.0;
        private static double englishMarks = 0.0;

        static void Main(string[] args)
        {
            string choice;

            do
            {
                Console.Clear();
                DisplayCourses();
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    DisplayDiploma();
                }
                else if (choice == "2")
                {
                    DisplayBIT();
                }
                else if (choice == "3")
                {
                    DisplayBCOM();
                }
                else if (choice == "4")
                {
                    DisplayDiplomaPartTime();
                }
                else if (choice == "5")
                {
                    DisplayBITPartTime();
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please enter a number between 1 and 5.");
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                }
            } while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5");
        }

        private static void CaptureStudentDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("After Each Question is answered, please press the Enter key.");

            Console.Write("Enter your Name: ");
            name = Console.ReadLine();

            Console.Write("Enter your Surname: ");
            surname = Console.ReadLine();

            Console.Write("Enter your Email Address: ");
            email = Console.ReadLine();

            Console.Write("Enter your Mathematics Marks during National Senior Certificate: ");
            while (!double.TryParse(Console.ReadLine(), out mathsMarks))
            {
                Console.Write("Invalid input. Please enter a valid numeric value for Mathematics Marks: ");
            }

            Console.Write("Enter your English Marks during National Senior Certificate: ");
            while (!double.TryParse(Console.ReadLine(), out englishMarks))
            {
                Console.Write("Invalid input. Please enter a valid numeric value for English Marks: ");
            }
        }

        private static void CheckDiplomaEligibility()
        {
            Console.WriteLine("Checking Eligibility for Diploma in Information Technology...");
            if (englishMarks >= 50 && mathsMarks >= 50)
            {
                Console.WriteLine("Congratulations! You meet the requirements for the Diploma in Information Technology.");
            }
            else if (englishMarks < 50)
            {
                Console.WriteLine("Unfortunately, you do not meet the English marks requirement (50% or higher).");
            }
            else if (mathsMarks < 50)
            {
                Console.WriteLine($"Unfortunately, you do not meet the Mathematics requirement 50% or higher).");
                Console.WriteLine("You can apply for the Mathematics Bridging Course to improve your eligibility.");
            }


        }

        private static void CheckDegreeEligibility(string programName, double requiredMathsMarks)
        {
            Console.WriteLine($"Checking Eligibility for {programName}...");
            if (englishMarks >= 50 && mathsMarks >= requiredMathsMarks)
            {
                Console.WriteLine($"Congratulations! You meet the requirements for the {programName}.");
            }
            else if (englishMarks < 50)
            {
                Console.WriteLine("Unfortunately, you do not meet the English marks requirement (50% or higher).");
            }
            else if (mathsMarks < requiredMathsMarks)
            {
                Console.WriteLine($"Unfortunately, you do not meet the Mathematics requirement ({requiredMathsMarks}% or higher).");
                Console.WriteLine("You can apply for the Mathematics Bridging Course to improve your eligibility.");
            }
        }

        private static void DisplayDiploma()
        {
            Console.WriteLine("You have selected the Diploma in Information Technology. Let's see if you can apply:");
            CaptureStudentDetails();
            CheckDiplomaEligibility();
        }

        private static void DisplayBCOM()
        {
            Console.WriteLine("You have selected the Bachelor of Computing. Let's see if you can apply:");
            CaptureStudentDetails();
            CheckDegreeEligibility("Bachelor of Computing", 70);
        }

        private static void DisplayBIT()
        {
            Console.WriteLine("You have selected the Bachelor in Information Technology. Let's see if you can apply:");
            CaptureStudentDetails();
            CheckDegreeEligibility("Bachelor of Information Technology", 50);
        }

        private static void DisplayDiplomaPartTime()
        {
            Console.WriteLine("You have selected the Diploma in Information Technology (Part-time). Let's see if you can apply:");
            CaptureStudentDetails();
            CheckDiplomaEligibility();
        }

        private static void DisplayBITPartTime()
        {
            Console.WriteLine("You have selected the Bachelor in Information Technology (Part-time). Let's see if you can apply:");
            CaptureStudentDetails();
            CheckDegreeEligibility("Bachelor of Information Technology (Part-time)", 50);
        }

        private static void DisplayCourses()
        {
            Console.WriteLine("Good day and Welcome to Belgium Campus Student Registration");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Please type in the number for the Course you would like to apply for and press Enter");
            Console.WriteLine("____________________________________________________________________________________");
            Console.WriteLine("1. Diploma in Information Technology");
            Console.WriteLine("2. Bachelor of Information Technology");
            Console.WriteLine("3. Bachelor in Computing");
            Console.WriteLine("4. Diploma in Information Technology (Part-time)");
            Console.WriteLine("5. Bachelor of Information Technology (Part-time)");
        }
    }
}
