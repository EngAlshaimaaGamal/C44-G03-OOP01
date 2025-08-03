using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    [Flags]
    internal enum Permission :Byte
    {
        write =1 ,
        read  =2,
         execute =4 ,
          delete  = 8 ,
          test=16,  

    }
}
