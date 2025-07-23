namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Boxing / UnBoxing

            #region  boxig [value type => reference type or object ] safe

            //int x = 44;
            //object y = x; // boxing
            //             // implacity 
            //             // take copy from vale to box in heap





            #endregion


            #region Unboxing [reference => value type] unsafe
            //object x = "Aliaa";
            //int y =(int ) x; // unboxing
            //                 //  explicity 
            //                 // unsage in run time

            //Console.WriteLine(y); //.InvalidCastException:


            #endregion


            #endregion


            #region Nullable value type 

            #region Example 1
            //int x = 10;
            //x = null; // invalid 

            //int? y = 10;
            //y = null;

            //Nullable<int> x = 10;
            //x = null; // valid  



            #endregion

            #region Example 2

            //int x = 10;
            //int? y = x;
            //// implicit conversion from int to Nullable<int>    

            //int? m = 10; //null;
            //int n =(int ) m;  // explicit conversion from Nullable<int> to int  unsafe

            //Console.WriteLine(n); // InvalidOperationException: Nullable object must have a value. if null ; 



            //int? x = null;
            //int y;
            //if (x is not null)
            //{
            //    y = (int )x;
            //}
            //else
            //    y= 0;


            //if (x.HasValue)
            //{
            //     y = x.Value; // safe

            //}
            //else
            //    y = 0;

            //  y = x.HasValue ? x.Value : 0;

            //y = x ?? 0; // null coalescing operator 

            //y = x.GetValueOrDefault(); // safe  

            //Console.WriteLine( y);
            //Console.WriteLine(x);







            #endregion


            #endregion





        }
    }
}
