using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class TypeB
    {

        public TypeB()
        {
            TypeA typeA = new TypeA();

            // typeA.Y = 5   // invalid becouse private only in scope only
            typeA.x = 6; // public  in scope and same assembly and out assembly
            typeA.z = 9; // valid internal in scope and same assembly only


        }

   


    }
}
