using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.	Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.


            //WeekDays Days = new WeekDays();

            //Days =(WeekDays) 1;
            //Console.WriteLine(Days); // Monday

            //Days = (WeekDays)2; 
            //Console.WriteLine(Days); // Tuesday 
            //Days = (WeekDays)3; 
            //Console.WriteLine(Days); // Wednesday   
            //Days = (WeekDays)4; 
            //Console.WriteLine(Days); // Thursday    
            //Days = (WeekDays)5;
            //Console.WriteLine(Days); // Friday
            //Days = (WeekDays)6;
            //Console.WriteLine(Days); // Saturday    


            #endregion

            #region Q2
            //2.	Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer June to August , autumn September to November , winter December to February)
            //

            //FourSeasons season;
            //bool isParsed;

            //do
            //{
            //    Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //    isParsed = Enum.TryParse<FourSeasons>(Console.ReadLine(), true, out season);

            //} while (!isParsed);

            //FourSeasons season1 = season;




            //using switch case 
            //switch (season1) 
            //{
            //  case FourSeasons.Spring:
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case FourSeasons.Summer:
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case FourSeasons.Autumn:
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case FourSeasons.Winter:
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid season entered.");
            //        break;

            //}















            //usng if else if   

            //if (season1 == FourSeasons.Spring)
            //{
            //    Console.WriteLine("Spring: March to May");
            //}
            //else if (season1 == FourSeasons.Summer)
            //{
            //    Console.WriteLine("Summer: June to August");
            //}
            //else if (season1 == FourSeasons.Autumn)
            //{
            //    Console.WriteLine("Autumn: September to November");
            //}
            //else if (season1 == FourSeasons.Winter)
            //{
            //    Console.WriteLine("Winter: December to February");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}






            #endregion



            #region Q3

            //Q3.Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum           .
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable

            //Users user01 = new Users();

            //user01.ID = 1;

            //user01.Permisssion = (Permissions)4;
            //Console.WriteLine(user01.Permisssion); // execute

            //user01.Permisssion |= Permissions.read;  //first way using or
            //Console.WriteLine(user01.Permisssion);  // add read

            //user01.Permisssion ^= Permissions.read;  //way using Xor remome read
            //Console.WriteLine(user01.Permisssion); // execute only

            //user01.Permisssion &= Permissions.delete;  // way using and  add dalete
            //Console.WriteLine(user01.Permisssion);  //0 not exsist

            //user01.Permisssion ^= Permissions.execute;  //way using Xor remome read
            //Console.WriteLine(user01.Permisssion);

            //bool hasPermisssion = user01.Permisssion.HasFlag(Permissions.execute);
            //if (hasPermisssion)
            //    Console.WriteLine("Has Permission");
            //else
            //    Console.WriteLine("Not has permission");









            #endregion

            #region Q4
            //4.	Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //bool isParsedColor;
            //Colors color;
            //do {

            //    Console.WriteLine("Enter a color :");
            //    isParsedColor = Enum.TryParse(Console.ReadLine(), true, out color);

            //}while(!isParsedColor) ;
        
            //if (color == Colors.Red) 
            //    Console.WriteLine("Red is a primary color.");
            //else if (color == Colors.Green) 
            //    Console.WriteLine("Green is a primary color.");
            //else if (color == Colors.Blue) 
            //    Console.WriteLine("Blue is a primary color.");
            //else
            //    Console.WriteLine("The color entered is not a primary color."); 





            #endregion

        }
    }
}
