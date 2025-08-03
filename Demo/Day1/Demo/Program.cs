using common;
using System.Security;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Access Modifer 
            //TypeA typeA = new TypeA();

            //  typeA.x = 1; // only public can access
            //  typeA.y = 6; // invalid private
            //  typeA.z = 8; // invalid internal


            #endregion


            #region Enum

            #region Example 01 

            //Person Person01 = new Person();
            //Person01.ID = 1;
            //Person01.Name = "John";
            //// Person01.Gender = "Female";

            //Person01.Gender = Gender.female; // using enum





            #endregion

            #region Example02
            //Grades Grad01 = new Grades();

            //Grad01 = Grades.A;
            // using enum
            // 

            //if (Grad01 == Grades.A|| Grad01 ==Grades.E)
            //  Console.WriteLine("Bravo");
            //else
            //  Console.WriteLine("Try Again");

            // Grad01 = (Grades)4 ;

            //Console.WriteLine(Grad01);

            //Gender Gender01 = new Gender();

            //Gender01 = Gender.Male;
            //Console.WriteLine(Gender01);



            #endregion

            #region Example03

            //Student student01 = new Student()
            //{
            //   ID = 5 , //store in 4bytes

            //    Name = "Ali",    // in 8 Byte
            //     Gender= Gender.Male, // 4bytes
            //    Grade = Grades.A, // 4bytes
            //    Branches = Branches.Dokki  //1byte

            //};



            #endregion


            #region Example 04 

            //Student std02 = new Student(); //   Student std02 = new();


            //Console.WriteLine("Enter the Date of Student :");
            //bool isParsed;
            //int stdID;

            //do
            //{

            //    Console.WriteLine("Enter the ID of Student :"); 
            //    isParsed = int.TryParse(Console.ReadLine(), out  stdID);

            //} while (!isParsed);
            //std02.ID = stdID;

            //Console.WriteLine("Enter the Name of Student :");   
            //std02.Name= Console.ReadLine();

            //object GenderInput;

            //do
            //{
            //    Console.WriteLine("Enter your Gender : ");
            //    isParsed = Enum.TryParse(typeof(Gender), Console.ReadLine(), out GenderInput);



            //} while (!isParsed || GenderInput is   null);

            //std02.Gender = (Gender)GenderInput;

            //Grades gradeInput;

            //do {

            //    Console.WriteLine("Enter your Grade :");
            //    isParsed = Enum.TryParse<Grades>(Console.ReadLine(), out gradeInput);


            //} while (!isParsed);

            //std02.Grade = gradeInput;

            //Branches branch;
            //do
            //{
            //    Console.WriteLine("Enter your branch :");
            //    isParsed = Enum.TryParse<Branches>(Console.ReadLine(), out branch);



            //} while (!isParsed);

            //std02.Branches= branch;
            //Console.Clear();



            //Console.WriteLine($" welcome  {std02.Name } in Rout with ID {std02.ID} and Grade {std02.Grade}  uour Gender {std02.Gender} and Branch is {std02.Branches}");





            #endregion


            #region Example 05
            // Users user01 = new Users();
            ///* {
            //     ID = 1,
            //     permission = new bool[4] { true, false, true, false } // 4 permission
            // };*/

            // user01.ID = 1; // 4 Bytes
            // user01.permission[0] = true;  // Read   
            // user01.permission[1] = false; // Write
            // user01.permission[2] = true;  // execute 
            // user01.permission[3] = false; // Delete 
            //                               // 4Bytes for all permission  
            // Users User02 = new Users();

            // User02.ID = 2;
            // User02.permission[0] = true;  // Read   
            // User02.permission[1] = true;  // Write  
            // User02.permission[2] = false; // execute    
            // User02.permission[3] = false; // Delete 


            //Users user01 = new Users();
            // user01.ID = 1;
            //user01.permission = (Permission)4;

            //Console.WriteLine(user01.permission);


            //Users user02 = new Users();

            //user02.ID = 2;
            //user02.permission = (Permission)10;

            //Console.WriteLine(user02.permission);



            //Users user03 = new Users();

            //user03.ID = 2;
            //user03.permission = (Permission)7;

            //Console.WriteLine(user03.permission);


            //Users user03 = new Users();

            //user03.ID = 2;
            //user03.permission = (Permission)3;

            //Console.WriteLine(user03.permission);


            //user03.permission =user03.permission ^ Permission.write; // 

            //Console.WriteLine(user03.permission);  // remove write permission    becouse it exists  


           // user03.permission = user03.permission ^ Permission.delete; // add delete permission 

            //Console.WriteLine(user03.permission);


            //user03.permission &= Permission.delete;
            // Console.WriteLine(user03.permission);


            //user03.permission &= Permission.execute;
            //Console.WriteLine(user03.permission);


            //if ((user03.permission & Permission.delete )== Permission.delete) 
            //{
            //    Console.WriteLine("User has delete permission");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have delete permission");


            //}




            //bool hasPermission = user03.permission.HasFlag(Permission.execute);

            //if (hasPermission)
            //{
            //    Console.WriteLine("User has execute permission");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have execute permission");

            //}
            //user03.permission |= Permission.execute;
            //Console.WriteLine(user03.permission);

            //user03.permission |= Permission.delete;
            //Console.WriteLine(user03.permission);




            #endregion


            #endregion














            //product prodect1 = new product()
            //{
            //    ID = 1,
            //    price = 100,
            //    Name = "Test",
            //    Description = "Testing",
            //    quantity = 1,   


            //};



        }
    }
}
