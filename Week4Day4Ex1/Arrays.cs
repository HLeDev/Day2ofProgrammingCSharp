using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day4Ex1
{
    class Arrays
    {
        public static void jaggedArray()
        {
            Console.WriteLine("\t Lets create a JaggedArray");
            Console.WriteLine("\t We will create a list of students, number of subject per student, and a grade for each subject");
            Console.WriteLine("\t Got it??  Let's begin");
            Console.WriteLine("\t ----------------------------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\t Please enter the number of students you wish to enter: ");

            //need to get number of student(s)
            int numStu = Convert.ToInt32(Console.ReadLine());
            int numCour;

            //Need to get the name per number of student
            //Introducing the student name in a separate array as a string
            string[] StudName;
            //Making student name = number of student 
            StudName = new string[numStu];
            for (int a = 0; a < numStu; a++)
            //for # of student entered on line 21, keep increasing (i++) until the number of student is less than max length (i < numStu) starting at 0 (i = 0)
            {
                Console.WriteLine($"\t Lets put in the Name of the student(s) starting from student {a} : ");
                StudName[a] = Console.ReadLine();
            }

            //now, to get the subject and grade in string and char respectively, first create a separate class for the get/set starting at (Line 76 - 86)
            //call the class jaggedarray, and create a new subject which is studentgrades
            //if we introduce it as int or char, then the characters will be limited, so creating a separate public class function help with resolving this issue
            Grade[][] studentgrades = new Grade[numStu][]; //we want the new subject to reference the number of students entered on (Line 21)
            for(int i = 0; i<studentgrades.Length; i++)
            {
                Console.WriteLine($"\t Please enter the number of subjects for student {StudName[i]} :"); 
                // StudName is referencing the inputted student name from (Line 33), and for this specific for loop, the number is referencing [i]
                numCour = Convert.ToInt32(Console.ReadLine());
                // Now we have to make sure the numCour will be pulling get/set from our Grade class on (Line 76) so we can enter a string per number of courses
                // and then making it = to this for loop
                studentgrades[i] = new Grade[numCour];

                //Once that's done, time to enter the grades per subject by creating and inner for loops
                for(int j = 0; j < studentgrades[i].Length; j++)
                {
                    Console.WriteLine($"\t Please enter the Subject name starting with subject {j}"); //this is saying enter the number of subject start with 0
                    string subj = Console.ReadLine(); //HERE WE GO!!! This is when we're calling a string from our Grade function
                    Console.WriteLine($"\t Please enter the grade for subject {subj}");
                    char grade = Convert.ToChar(Console.ReadLine()); //This is when we're calling char from Grade function!
                    studentgrades[i][j] = new Grade(subj, grade);
                    //What this inner for loop is saying is that:
                    //for x number of course(s), enter subject name and grade of that specific subject until numCour is maxed out.
                }
            }

            // Once we have all the information, now it's time to print this
            Console.Write("\t The Student Grades are is as followed: \n");
            Console.Write("\t -----------------------------------------");
            for (int i = 0; i < numStu; i++)
            {
                Console.Write("\n");

                for (int j = 0; j < studentgrades[i].Length; j++)
                {
                    Console.Write($"\t Student {StudName[i]} | Subject { studentgrades[i][j].subj} | Grade { studentgrades[i][j].grade}|");
                    //now we're writing out and the student name, the [i] is from the for loop in this for loop
                    //studentgrades[i][j] from line 55, calling the subj from our Grade fuction, the subject was entered on (Line 53)
                    //and then the grade for that subject, which was enter on (Line 55)
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\t Now that you see how JaggedArray is created, lets move on!");
            Console.WriteLine("\t -------------------------------");
            Console.WriteLine("\t Lets go back to the main menu!");
            Console.WriteLine("\t ------------------------------");
        }
        public class Grade
        {
            public string subj { get; set; }
            public char grade { get; set; }
            public Grade(string subj, char grade)
            {
                this.grade = grade;
                this.subj = subj;
            }
        }
        public static void array2D()
        {

            Console.WriteLine("\t Lets create a 2D array!");
            Console.WriteLine("\t To start off, how many row would you like?");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t How many column would you like?");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] array2D = new int[row, column];
            //creating 2d arrays for number of row(s) and column(s) 
            //adding the row/colum into a 2D array function

            for (int e = 0; e < row; e++)
            {
                for (int f = 0; f < column; f++)
                {
                    Console.WriteLine($"\t Please enter your number for row {e} column {f}");
                    array2D[e, f] = Convert.ToInt32(Console.ReadLine());

                }
                //for row starting at 0 go to each column until max, then repeat on next row, enter the numbers in sequential order
            }
            Console.Write("\t The 2D Array is as followed: \n");
            Console.Write("\t -------------------------------");
            for (int e = 0; e < row; e++)
            {
                Console.Write("\n");
                for (int f = 0; f < column; f++)
                {
                    Console.Write($"\t Row {e} [ {array2D[e, f]} ] ");
                }

                //this is to write out the number per row and column in sequential order that it was put in
            }
            Console.WriteLine("\n");
            Console.WriteLine("\t Now that you see how 2D array is created, lets move on!");
            Console.WriteLine("\t -------------------------------");
            Console.WriteLine("\t Going back to the main menu now");
            Console.WriteLine("\t ------------------------------");
        }
    }

}
