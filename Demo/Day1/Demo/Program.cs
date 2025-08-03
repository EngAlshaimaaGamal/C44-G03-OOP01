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
