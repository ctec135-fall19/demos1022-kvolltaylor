using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class MyClass
    {
        // fields
        // 
        private string str;
        private string str2;

        // constructor to create object
        public MyClass(string inStr)
        {
            // composition
            // MyClass owns str. str doesn't exist outside of MyClass
            str = "some string";

            // aggregation
            // inStr is referring to some object that exists outside of MyClass
            // if im passing things in by reference its aggregation
            str2 = inStr;
        }

        public void printState()
        {
            Console.WriteLine("str: {0}", str);
            Console.WriteLine("str2: {0}", str2);
        }

        // Example of a nested class:
        //class MyNestedClass
        //{
        //}
        // nestedd classes are a way to encapsulate utility behavior 
        // can create a utility class seperately though, do not need to nest necessarily



    }
}
