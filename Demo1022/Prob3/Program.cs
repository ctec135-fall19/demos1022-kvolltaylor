using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // s only exists in Main
            string s = "string from Main";

            // pass s by reference to MyClass
            MyClass mc = new MyClass(s);

         
            mc.printState();
        }
    }
}
