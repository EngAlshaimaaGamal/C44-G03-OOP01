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

        }
    }
}
