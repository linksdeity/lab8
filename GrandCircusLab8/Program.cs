using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] students = new string[20, 3];

            students[0, 0] = "Jack Bowen";
            students[0, 1] = "Detroit";
            students[0, 2] = "Pizza";

            students[1, 0] = "Heather Saunders";
            students[1, 1] = "Detroit";
            students[1, 2] = "Tacos";

            students[2, 0] = "Daren Allen";
            students[2, 1] = "Sandusky";
            students[2, 2] = "Noodles";

            students[3, 0] = "Allen Wrenchman";
            students[3, 1] = "Ann Arbor";
            students[3, 2] = "Pasta";

            students[4, 0] = "Karen Jenkmen";
            students[4, 1] = "Detroit";
            students[4, 2] = "Subs";

            students[5, 0] = "Darrel Jones";
            students[5, 1] = "Allen Park";
            students[5, 2] = "Chocolate";

            students[6, 0] = "Hank Hill";
            students[6, 1] = "Arlington";
            students[6, 2] = "Anything grilled with propane";

            students[7, 0] = "Sara McDargg";
            students[7, 1] = "Miami";
            students[7, 2] = "Churros";

            students[8, 0] = "Bilbo Bagins";
            students[8, 1] = "Shire";
            students[8, 2] = "Pie";

            students[9, 0] = "Link";
            students[9, 1] = "Kokiri Forest";
            students[9, 2] = "Moblin";

            students[10, 0] = "Darnel Dashins";
            students[10, 1] = "Detroit";
            students[10, 2] = "Hot Dogs";

            students[11, 0] = "Carrel Conrad";
            students[11, 1] = "Fort Worth";
            students[11, 2] = "Candy";

            students[12, 0] = "Larry David";
            students[12, 1] = "New York";
            students[12, 2] = "Angle Food Cake";

            students[13, 0] = "George Oscar Bluth";
            students[13, 1] = "Sudden Valley";
            students[13, 2] = "Frozen Banana";

            students[14, 0] = "John Rambo";
            students[14, 1] = "Vietnam";
            students[14, 2] = "the taste of freedom";

            students[15, 0] = "Julie Shifer";
            students[15, 1] = "Boston";
            students[15, 2] = "Crab";

            students[16, 0] = "Sarah Sarfel";
            students[16, 1] = "Lincoln Park";
            students[16, 2] = "Toast";

            students[17, 0] = "Joshua Zime";
            students[17, 1] = "Detroit";
            students[17, 2] = "Sloppy Joes";

            students[18, 0] = "Gertrude Malificent";
            students[18, 1] = "Detroit";
            students[18, 2] = "Apples";

            students[19, 0] = "Homer Simpson";
            students[19, 1] = "Springfield";
            students[19, 2] = "Donuts";

            int location = 0;

            while (true)

            {
                while (true)
                {
                    Console.WriteLine("Welcome to class. Which student would you like to learn more about?\n(Enter a number 1-20)");

                    //format handling
                    try
                    {
                        location = Int32.Parse(Console.ReadLine());

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please only enter a number!\n\n");
                        continue;
                    }

                    //range handling
                    try
                    {
                        string test = students[location - 1, 0];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Student does not exist!\n\n");
                        continue;
                    }

                    break;
                }

                Console.Clear();

                string info = "";

                while (info == "")
                {
                    Console.WriteLine("Student number {0} is {1}", location, students[location - 1, 0]);

                    Console.WriteLine("Would you like to know their 'hometown' or their 'favorite food' ?");

                    string option = Console.ReadLine();

                    //call method to find student info
                    info = (ReturnInfo(students, location, option));

                    Console.WriteLine(info);
                }



                Console.WriteLine("\n\nWould you like to continue searching?\n\n('y' for yes, anything else to quit!)");

                char answer = Console.ReadKey(true).KeyChar;

                if(answer == 'y' || answer == 'Y')
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("Goodbye!!!\n\n(press any key...)");
            Console.ReadKey();
        }

    
        //method to pull student's info
        static string ReturnInfo(string[,] students, int location, string option)
        {
            
            if (option == "hometown")
            {
                string saver = (students[location - 1, 0] + "'s hometown is " + students[location - 1, 1]);
                return saver;
            }
            else if (option == "favorite food")
            {
                string saver = students[location - 1, 0] + "'s favorite food is " + students[location - 1, 2];
                return saver;
            }
            else
            {
                Console.WriteLine("Please only type 'hometown' or 'favorite food'!");
                return "";                
            }

            
        }






    }
}
