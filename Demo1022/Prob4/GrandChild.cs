using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class GrandChild : Child
    {

        // Demonstrate overriding a base class by a child
        // uses override keyword
        public override void SomeMethod()
        {
            Console.WriteLine("GrandChild's SomeMethod");
        }

        // Demonstrate a child method calling the parent's method
        public override void Method2()
        {
            // base only goes up 1 tier
            // there is no way to go all the way to the top
            // here you are only calling Child, not Parent
            // so this is a stack of calls: the GrandChild calls on the 
            // Child method, and the Child method calls on the Parent
            base.Method2();
            Console.WriteLine("GrandChild.Method2");
        }

        public void SpecializedMethod()
        {
            Console.WriteLine("Specialized Method");
        }

    }
}
