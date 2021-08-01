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

            //getting student name base on number of student
            string[] StudName;
            StudName = new string[numStu];
            for (int a = 0; a < numStu; a++)
            {
                Console.WriteLine($"\t Lets put in the student Name starting from student {a} : ");
                StudName[a] = Console.ReadLine();
            }

            Grade[][] studentgrades = new Grade[numStu][];
            for(int i = 0; i<studentgrades.Length; i++)
            {
                Console.WriteLine($"\t Please enter the number of subjects for each student starting with student {StudName[i]} :");
                numCour = Convert.ToInt32(Console.ReadLine());

                studentgrades[i] = new Grade[numCour];

                for(int j = 0; j < studentgrades[i].Length; j++)
                {
                    Console.WriteLine("\t Please enter the Subject name starting with subject {0}");
                    string subj = Console.ReadLine();
                    Console.WriteLine($"\t Please enter the grade for subject {subj}");
                    char grade = Convert.ToChar(Console.ReadLine());
                    studentgrades[i][j] = new Grade(subj, grade);
                }
                //for every number of student which is the index i, assign x number of subject [j] (Line 23 - 28)
                //for every number of student [i], going into each specific subject [j], enter a grade for each until [i] and [j] length is maxed out (Line 30-33)
            }

            Console.Write("\t The Student Grades are is as followed: \n");
            Console.Write("\t -----------------------------------------");
            for (int i = 0; i < numStu; i++)
            {
                Console.Write("\n");

                for (int j = 0; j < studentgrades[i].Length; j++)
                {
                    Console.Write($"\t Student {StudName[i]} | Subject { studentgrades[i][j].subj} | Grade { studentgrades[i][j].grade}|");
                }
                //for every number of students [i] and subject [j] write out the grades of each student per subject until max
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
