using System;

namespace butlerQ_Deliverable2_Conditional
{
    /*
    Author: Quinn Butler
    Date: 1/27/2021
    Comments: C# console application demonstrating conditional statements based on input
    */
    class Program
    {
        static void Main(string[] args)
        {
            /* Deliverable requirements are the following:
            PROGRAM #1: Based on what you have learned from the Conditional Statement example, write a C# Console Program with Conditional Statements that does the following: 

            1.Ask the user what grade they expect to get in ISM 4300.They should enter an integer value.

            2.Based on what the user has entered, have the program display their Letter grade per Syllabus for this course.

            Once you complete this program, upload it to GitHub.

            Then, paste in your GitHub Link to GitHub here. 
            
            Per the requirements of the deliverable, we require our console to print text asking the user to enter an integer value, have the user enter that integer value, logic check the input to verify if it's an integer value, calculate/determine
            the range of which that integer value falls, and print the letter grade.
            A+:     >=98
            A:      >=92
            A-:     >=90
            B+:     >=88
            B:      >=82
            B-:     >=80
            C+:     >=78
            C:      >=72
            C-:     >=70
            D+:     >=68
            D:      >=62
            D-:     >=60
            F:      Else
             */
            //For this case, declaring a variable in the beginning for the letter grade variable to default to N/A and it would be calculated through the conditional statements
            string gradeLetter = "N/A";
            Console.WriteLine("Please enter an integer value of your expected grade in ISM 4300:");
            //Try catch block to validate user input of integer and to handle error based on input
            try
            {
                //User input variable for grade value
                string userInput = Console.ReadLine();
                //Variable to parse user input and store as integer
                int gradeValue = int.Parse(userInput);
                //Test gradeValue variable to change letter grade variable for output
                if (gradeValue >= 98)
                    gradeLetter = "A+";
                else if (gradeValue >= 92)
                    gradeLetter = "A";
                else if (gradeValue >= 90)
                    gradeLetter = "A-";
                else if (gradeValue >= 88)
                    gradeLetter = "B+";
                else if (gradeValue >= 82)
                    gradeLetter = "B";
                else if (gradeValue >= 80)
                    gradeLetter = "B-";
                else if (gradeValue >= 78)
                    gradeLetter = "C+";
                else if (gradeValue >= 72)
                    gradeLetter = "C";
                else if (gradeValue >= 70)
                    gradeLetter = "C-";
                else if (gradeValue >= 68)
                    gradeLetter = "D+";
                else if (gradeValue >= 62)
                    gradeLetter = "D";
                else if (gradeValue >= 60)
                    gradeLetter = "D-";
                else gradeLetter = "F";
                //Print combined string output of generic letter grade output and gradeLetter result string
                Console.WriteLine("Your letter grade per the syllabus is: " + gradeLetter);
                //Print string stating that user can enter any key to exit, and user's console will close
                Console.WriteLine("Press any key to exit program.");
                Console.ReadKey(true);
            }
            catch
            {
                //Print message that user inputted incorrect value for console
                Console.WriteLine("Please enter a valid integer value.");
                //Print string stating that user can enter any key to exit, and user's console will close
                Console.WriteLine("Press any key to exit program.");
                Console.ReadKey(true);
            }

        }
    }
}
