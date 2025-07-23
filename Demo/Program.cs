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






        }
    }
}
