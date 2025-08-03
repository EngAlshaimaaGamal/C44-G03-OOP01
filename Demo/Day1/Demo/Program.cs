using common;

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
