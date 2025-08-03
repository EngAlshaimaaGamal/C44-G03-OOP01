using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Flags]
    internal enum Permissions :byte
    {
        read =1,
        write =2 ,
        execute =4 , 
        delete =8   


    }
}
